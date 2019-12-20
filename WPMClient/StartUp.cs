﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using WPMClient.SysModule;
using WPMPublicLib.HttpHelper;

namespace WPMClient
{
    /// <summary>
    /// 起始类
    /// </summary>
    public class StartUp
    {
        /// <summary>
        /// 构造函数
        /// </summary>
        public StartUp()
        { 
            //初始化全局缓存类
            //初始化 日志记录工具
            //初始化 数据库访问类
            HttpHelper.Init(@"http://localhost/WPMServer/Handler/");
        }

        public void Run()
        {
            LoginFrm login = new LoginFrm();
            var res = login.ShowDialog();
            if(DialogResult.OK == res)
            {
                login.Close();
                login.Dispose();
                Application.Run(new MainForm());
            }
            
        }
    }
}
