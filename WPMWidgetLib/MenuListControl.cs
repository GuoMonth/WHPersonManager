using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WPMWidgetLib
{
    public partial class MenuListControl : UserControl
    {
        private Action<string, string, string, string> m_afterSelect;

        /// <summary>
        /// 委托 节点选择后触发执行
        /// 四个string类型参数，依次为：MenuId、DllName、NameSpace、ClassName
        /// </summary>
        public Action<string, string, string, string> m_AfterSelect 
        {
            get
            {
                return this.m_afterSelect;
            }
            set
            {

                if (this.m_afterSelect == null)
                {
                    this.m_afterSelect = value;
                }
                else
                {
                    lock (this.m_afterSelect)
                    {
                        this.m_afterSelect += value;
                    }
                }
            }
        }

        #region 构造函数

        /// <summary>
        /// 无参构造函数
        /// </summary>
        public MenuListControl()
        {
            InitializeComponent();
            
        }

        #endregion

        #region 方法

        /// <summary>
        /// 初始化菜单列表
        /// 最多只支持二级菜单
        /// </summary>
        public void InitMenu(IEnumerable<EntityMenu> menuList)
        {
            this.treeViewMenu.Nodes.Clear();
            //父节点
            TreeNode tn_p;
            //子节点
            TreeNode tn_c;
            foreach(var v in menuList.Where(c=>string.IsNullOrEmpty(c.m_ParentMenuId)))
            {   
                //赋值父节点
                tn_p = new TreeNode();
                tn_p.Text = v.m_ShowName;
                tn_p.ToolTipText = v.m_ShowName;
                tn_p.Tag = v;
                this.treeViewMenu.Nodes.Add(tn_p);
                foreach (var y in menuList.Where(c => c.m_ParentMenuId==v.m_MenuId))
                {
                    //赋值子节点
                    tn_c = new TreeNode();
                    tn_c.Text = y.m_ShowName;
                    tn_c.ToolTipText = y.m_ShowName;
                    tn_c.Tag = y;
                    tn_p.Nodes.Add(tn_c);

                }
            }
        }

        #endregion

        #region 事件

        /// <summary>
        /// 更改节点选项后触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void treeViewMenu_AfterSelect(object sender, TreeViewEventArgs e)
        {
            var action = m_AfterSelect; //避免m_AfterSelect瞬间被置为null的情况 虽然此处几乎不会发生 但应保持优良习惯
            if (action != null)
            {
                EntityMenu entityMenu = e.Node.Tag as EntityMenu;
                action(entityMenu.m_MenuId,entityMenu.m_DllName,entityMenu.m_NameSpace,entityMenu.m_ClassName);
            }
        }

        #endregion
    }

    /// <summary>
    /// 菜单项目实体类
    /// </summary>
    public class EntityMenu
    {
        /// <summary>
        /// 菜单ID
        /// </summary>
        public string m_MenuId
        {
            get;
            set;
        }

        /// <summary>
        /// dll名称
        /// </summary>
        public string m_DllName
        {
            get;
            set;
        }

        /// <summary>
        /// 命名空间
        /// </summary>
        public string m_NameSpace
        {
            get;
            set;
        }

        /// <summary>
        /// 类名
        /// </summary>
        public string m_ClassName
        {
            get;
            set;
        }

        /// <summary>
        /// 显示名称
        /// </summary>
        public string m_ShowName
        {
            get;
            set;
        }

        /// <summary>
        /// 父菜单ID
        /// </summary>
        public string m_ParentMenuId
        {
            get;
            set;
        }

    }
}
