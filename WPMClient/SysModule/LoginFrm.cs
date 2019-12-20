using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WPMPublicLib.HttpHelper;

namespace WPMClient.SysModule
{
    public partial class LoginFrm : Form
    {     
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void btn_SingIn_Click(object sender, EventArgs e)
        {
            //搜集登录用户名、密码
            string loginName = this.txt_LoginName.Text;
            string passWord = this.txt_Password.Text;
            string queryUser = string.Format(@"select ID from sys_users su 
                                                where su.login_name = '{0}' and su.password = '{1}'"
                , loginName, passWord);
            DataTable queryUserDt =  HttpHelper.ExecuteQuery(queryUser);
            if (queryUserDt !=null && queryUserDt.Rows.Count > 0) 
            {
                //校验通过进入主程序 
                DialogResult = System.Windows.Forms.DialogResult.OK;

            }
            else
            {
                MessageBox.Show("用户名或密码错误");
                DialogResult = System.Windows.Forms.DialogResult.Cancel;
            }
        }
    }
}
