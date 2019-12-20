using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WPMPublicLib.HttpHelper;
using WPMWidgetLib;

namespace WPMClient
{
    public partial class MainForm : Form
    {
        #region 静态资源
       
        public static readonly string s_QueryMenu = @"select sm.menu_id,sm.dll_name,sm.name_space,sm.class_name,sm.show_name,sm.parent_menu_id from sys_menu sm";

        #endregion

        #region 构造函数


        public MainForm()
        {
            InitializeComponent();
        }

        #endregion

        #region 事件

        /// <summary>
        /// 加载页面触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            //加载菜单
           this.InitMenu();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        #endregion

        #region 方法

        /// <summary>
        /// 加载菜单
        /// </summary>
        private void InitMenu()
        {

            DataTable dtMenu = HttpHelper.ExecuteQuery(s_QueryMenu);

            if (dtMenu == null || dtMenu.Rows.Count < 1)
            {
                MessageBox.Show("后台查询菜单数据为空！");
                return;
            }

            List<EntityMenu> listMenu = new List<EntityMenu>();
            EntityMenu menu;
            foreach (DataRow drMenu in dtMenu.Rows)
            {
                menu = new EntityMenu();
                menu.m_ClassName = drMenu["class_name"].ToString();
                menu.m_DllName = drMenu["dll_name"].ToString();
                menu.m_MenuId = drMenu["menu_id"].ToString();
                menu.m_NameSpace = drMenu["name_space"].ToString();
                menu.m_ParentMenuId = drMenu["parent_menu_id"].ToString();
                menu.m_ShowName = drMenu["show_name"].ToString();
                listMenu.Add(menu);
            }
            this.menuListControl1.InitMenu(listMenu);

           
        }

        #endregion
    }
}
