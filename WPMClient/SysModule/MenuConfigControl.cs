using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WPMWidgetLib;
using WPMPublicLib.HttpHelper;

namespace WPMClient.SysModule
{
    public partial class MenuConfigControl : IControl
    {
        private static string m_insertSql = @"
                                    INSERT INTO SYS_MENU
                                    (MENU_ID,DLL_NAME,NAME_SPACE,CLASS_NAME,SHOW_NAME,PARENT_MENU_ID,creator_id,creator_name,creator_time)
                                    VALUES
                                    (substr(sys_guid(),23),'{0}','{1}','{2}','{3}','{4}','{5}','{6}',SYSDATE)
                                    ";

        public MenuConfigControl()
        {
            InitializeComponent();
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            //校验
            if (string.IsNullOrEmpty(this.txt_dllName.Text))
                MessageBox.Show("dll文件路径不能为空");
            if (string.IsNullOrEmpty(this.txt_nameSpace.Text))
                MessageBox.Show("命名空间不能为空");
            if (string.IsNullOrEmpty(this.txt_className.Text))
                MessageBox.Show("类名不能为空");
            if (string.IsNullOrEmpty(this.txt_showName.Text))
                MessageBox.Show("菜单显示名称不能为空");

            string insertSql = string.Format(m_insertSql
                , this.txt_dllName.Text,this.txt_nameSpace.Text,this.txt_className.Text
                ,this.txt_showName.Text,this.txt_fatherID.Text,"007","007");

            DataTable dt = new DataTable();
            dt.Columns.Add("1",typeof(string));

            HttpHelper.ExecuteNonQuery(insertSql,null);
        }
    }
}
