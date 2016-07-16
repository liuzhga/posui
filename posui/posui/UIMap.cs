﻿namespace posui
{
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using System;
    using System.Collections.Generic;
    using System.CodeDom.Compiler;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    using System.Drawing;
    using System.Windows.Input;
    using System.Text.RegularExpressions;


    public partial class UIMap
    {
        public virtual loginParams loginParams
        {
            get
            {
                if ((this.mloginParams == null))
                {
                    this.mloginParams = new loginParams();
                }
                return this.mloginParams;
            }
        }
        private loginParams mloginParams;


        public void ExitCashierMenoSelect(int oper)
        {
            #region Variable Declarations

            #endregion
            switch (oper)
            {
                case 1:
                    WinEdit exitcashiere = this.UI收银界面esc菜单选择Window.UINoneClient.退出收银;
                    Keyboard.SendKeys(exitcashiere, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 2:
                    WinEdit salesreturn = this.UI收银界面esc菜单选择Window.UINoneClient.退货;
                    Keyboard.SendKeys(salesreturn, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 3:
                    WinEdit retailGift = this.UI收银界面esc菜单选择Window.UINoneClient.整单赠送;
                    Keyboard.SendKeys(retailGift, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 4:
                    WinEdit retailRegister = this.UI收银界面esc菜单选择Window.UINoneClient.商品暂存;
                    Keyboard.SendKeys(retailRegister, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 5:
                    WinEdit registerPickup = this.UI收银界面esc菜单选择Window.UINoneClient.暂存取货;
                    Keyboard.SendKeys(registerPickup, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 6:
                    WinEdit registerQuery = this.UI收银界面esc菜单选择Window.UINoneClient.暂存查询;
                    Keyboard.SendKeys(registerQuery, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 7:
                    WinEdit checkAndPay = this.UI收银界面esc菜单选择Window.UINoneClient.对账交款;
                    Keyboard.SendKeys(checkAndPay, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 8:
                    WinEdit returnCashier = this.UI收银界面esc菜单选择Window.UINoneClient.返回;
                    Keyboard.SendKeys(returnCashier, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
            }

        }

        /// <summary>
        /// 主菜单选择函数
        /// </summary>
        public void MainMenoSelect(int oper)
        {
            #region Variable Declarations
            
            #endregion

            // 在 “提示信息” 客户端 中键入“{Enter}”

            switch (oper)
            {
                case 1:
                    WinEdit cashiere = this.UI主菜单选择Window.主菜单选择.前台收银;
                    Keyboard.SendKeys(cashiere, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 2:
                    WinEdit onduty = this.UI主菜单选择Window.主菜单选择.当班;
                    Keyboard.SendKeys(onduty, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 3:
                    WinEdit shift = this.UI主菜单选择Window.主菜单选择.交班;
                    Keyboard.SendKeys(shift, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 4:
                    WinEdit cashierPractice = this.UI主菜单选择Window.主菜单选择.练习收银;
                    Keyboard.SendKeys(cashierPractice, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 5:
                    WinEdit parameterSet = this.UI主菜单选择Window.主菜单选择.参数设置;
                    Keyboard.SendKeys(parameterSet, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 6:
                    WinEdit daily = this.UI主菜单选择Window.主菜单选择.日结;
                    Keyboard.SendKeys(daily, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 7:
                    WinEdit detailedQuery = this.UI主菜单选择Window.主菜单选择.明细查询;
                    Keyboard.SendKeys(detailedQuery, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 8:
                    WinEdit datasync = this.UI主菜单选择Window.主菜单选择.数据同步;
                    Keyboard.SendKeys(datasync, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 9:
                    WinEdit passwordChange = this.UI主菜单选择Window.主菜单选择.修改密码;
                    Keyboard.SendKeys(passwordChange, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 10:
                    WinEdit relogin = this.UI主菜单选择Window.主菜单选择.重新登录;
                    Keyboard.SendKeys(relogin, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
                case 11:
                    WinEdit logout = this.UI主菜单选择Window.主菜单选择.退出系统;
                    Keyboard.SendKeys(logout, loginParams.SendZero, ModifierKeys.None);
                    WinClient uI确定当班提示信息Client = this.UI提示信息Window.UI提示信息窗口有后续流程Client;
                    Keyboard.SendKeys(uI确定当班提示信息Client, this.loginParams.SendEnter, ModifierKeys.None);
                    break;
            }

        }
        /// <summary>
        /// 登录
        /// </summary>
        public void Login()
        {
            #region Variable Declarations

            WinEdit uIcodeEdit = this.UI收银员登录Window.UI收银员子Window.收银员编码;
            WinEdit uIsecWinEdit = this.UI收银员登录Window.UI收银员登录子Window1.收银员密码;

            #endregion

            // 启动“%ProgramFiles%\Chanjet\Pos\ufida_t_pos_app.exe”
            ApplicationUnderTest ufida_t_pos_appApplication = ApplicationUnderTest.Launch(this.loginParams.ExePath,
                this.loginParams.AlternateExePath);

            // 在 文本框 中键入“1”
            uIcodeEdit.Text = this.loginParams.SendOne;

            // 在 文本框 中键入“{Enter}”
            Keyboard.SendKeys(uIcodeEdit, this.loginParams.SendEnter, ModifierKeys.None);

            // 在 文本框 中键入“{Enter}”
            Keyboard.SendKeys(uIsecWinEdit, this.loginParams.SendEnter, ModifierKeys.None);
        }

        /// <summary>
        /// 当班
        /// </summary>

        public void OnDuty()
        {
            #region Variable Declarations
            WinComboBox uI班次选择控件 = this.UI当班Window1.UI当班子Window.UI班次选择控件;
            WinClient uI提示信息Client = this.UI提示信息Window.UI提示信息窗口有后续流程Client;
            WinEdit uIItemEdit = this.UI当班Window1.UIItemWindow.UIItemEdit;

            #endregion
            //主菜单选择当班
            MainMenoSelect(loginParams.Onduty);

            // 在 组合框 中选择“晚班                                                                                                    1650”
            uI班次选择控件.SelectedItem = this.loginParams.UIComboBoxSelectedNight;

            // 在 组合框 中键入“{Enter}”
            Keyboard.SendKeys(uI班次选择控件, this.loginParams.SendEnter, ModifierKeys.None);
            // 在 备用金文本框 中键入“{Enter}”
            Keyboard.SendKeys(uIItemEdit, this.loginParams.SendEnter, ModifierKeys.None);

            // 在 “当班提示信息” 客户端 中键入“{Enter}”
            Keyboard.SendKeys(uI提示信息Client, this.loginParams.SendEnter, ModifierKeys.None);

        }



        /// <summary>
        /// chushihua - 使用“chushihuaParams”将参数传递到此方法中。
        /// </summary>
        public void Firstlogin()
        {
            #region Variable Declarations

            WinEdit uIItemEdit = this.UI服务器连接设置Window.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit1 = this.UI服务器连接设置Window.UIItemWindow1.UIItemEdit;
            WinEdit uIItemEdit2 = this.UI选择账套Window.UIItemWindow.UIItemEdit;
            WinEdit uIItemEdit3 = this.UI选择账套Window.UIItemWindow1.UIItemEdit;
            WinComboBox uIItemComboBox = this.UI选择账套Window.UIItemWindow2.UIItemComboBox;
            WinComboBox uIItemComboBox1 = this.UI选择账套Window.UIItemWindow3.UIItemComboBox;
            WinEdit uIItemEdit4 = this.UI选择账套Window.UIItemWindow4.UIItemEdit;
            WinText uI是否手工下载数据Text = this.UI提示信息Window.UIItemWindow.UI是否手工下载数据Text;
            WinClient uI确定当班提示信息Client = this.UI提示信息Window.UI提示信息窗口有后续流程Client;
            #endregion

            // 启动“%ProgramFiles%\Chanjet\Pos\ufida_t_pos_app.exe”
            ApplicationUnderTest ufida_t_pos_appApplication = ApplicationUnderTest.Launch(this.loginParams.ExePath,
                this.loginParams.AlternateExePath);


            // 在 文本框 中键入“http://127.0.0.1:8080/tplus”
            uIItemEdit.Text = this.loginParams.ServerAddress;

            // 在 文本框 中键入“{Tab}”
            Keyboard.SendKeys(uIItemEdit, this.loginParams.SendTab, ModifierKeys.None);

            // 在 文本框 中键入“8080”
            uIItemEdit1.Text = this.loginParams.ServerPort;

            // 在 文本框 中键入“{Enter}”
            Keyboard.SendKeys(uIItemEdit1, this.loginParams.SendEnter, ModifierKeys.None);

            // 在 文本框 中键入“1”
            uIItemEdit2.Text = this.loginParams.SendOne;

            // 在 文本框 中键入“{Enter}”
            Keyboard.SendKeys(uIItemEdit2, this.loginParams.SendEnter, ModifierKeys.None);

            // 在 文本框 中键入“{Enter}”
            Keyboard.SendKeys(uIItemEdit3, this.loginParams.SendEnter, ModifierKeys.None);

            // 在 组合框 中键入“{Enter}”
            Keyboard.SendKeys(uIItemComboBox, this.loginParams.SendEnter, ModifierKeys.None);

            // 在 组合框 中键入“{Enter}”
            Keyboard.SendKeys(uIItemComboBox1, this.loginParams.SendEnter, ModifierKeys.None);

            // 在 文本框 中键入“a010001”
            uIItemEdit4.Text = this.loginParams.PosCode;

            // 在 文本框 中键入“{Enter}”
            Keyboard.SendKeys(uIItemEdit4, this.loginParams.SendEnter, ModifierKeys.None);

            // 单击 “是否手工下载数据？” 标签
            Mouse.Click(uI是否手工下载数据Text, new Point(208, 34));

            // 在 “提示信息” 客户端 中键入“{F3}”
            Keyboard.SendKeys(uI确定当班提示信息Client, this.loginParams.SendF3, ModifierKeys.None);
        }

        /// <summary>
        /// shift - 使用“shiftParams”将参数传递到此方法中。
        /// </summary>
        public void shift()
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UI交班Window.UIItemWindow.UIItemEdit;
            WinClient uI确定当班提示信息Client = this.UI提示信息Window.UI提示信息窗口有后续流程Client;
            #endregion

            // 选择交班菜单。
            MainMenoSelect(loginParams.Shift);
            // 在 文本框 中键入“{F2}”
            Keyboard.SendKeys(uIItemEdit, this.loginParams.SendF2, ModifierKeys.None);

            // 在 “提示信息” 客户端 中键入“{F2}”
            Keyboard.SendKeys(uI确定当班提示信息Client, this.loginParams.SendF3, ModifierKeys.None);
        }


        /// <summary>
        /// 在收银界面退出
        /// </summary>
        public void ExitCashier()
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UI畅捷通T零售POS软件Window.UIItem1234567890123Window.UIItemEdit;
            #endregion

            // 在 文本框 中键入“{Escape}”
            Keyboard.SendKeys(uIItemEdit, this.loginParams.SendEsc, ModifierKeys.None);
            ExitCashierMenoSelect(loginParams.Exitcashier);
        }

    }
    /// <summary>
    /// 参数表
    /// </summary>
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class loginParams
    {
        #region Fields
        public string ExePath = "C:\\Program Files (x86)\\Chanjet\\Pos\\ufida_t_pos_app.exe";
        public string AlternateExePath = "%ProgramFiles%\\Chanjet\\Pos\\ufida_t_pos_app.exe";

        public string UIComboBoxSelectedMorning = "早班                                                                               " +
    "                     1648";
        public string UIComboBoxSelectedMid = "中班                                                                               " +
    "                     1649";

        public string UIComboBoxSelectedNight = "晚班                                                                               " +
    "                     1650";

        public string ServerAddress = "http://127.0.0.1:8080/tplus";
        public string ServerPort = "8080";
        public string PosCode = "a010001";

        public string SendOne = "1";
        public string SendZero = "0";
        public string SendEnter = "{Enter}";
        public string SendTab = "{Tab}";
        public string SendEsc = "{Escape}";
        public string SendF3 = "{F3}";
        public string SendF2 = "{F2}";


        public int Cashier = 1;
        public int Onduty = 2;
        public int Shift = 3;
        public int CashierPractice = 4;
        public int ParameterSet = 5;
        public int Daily = 6;
        public int DetailedQuery = 7;
        public int Datasync = 8;
        public int PasswordChange = 9;
        public int Relogin = 10;
        public int Logout = 11;

        public int Exitcashier = 1;
        public int Salesreturn = 2;
        public int RetailGift = 3;
        public int RetailRegister = 4;
        public int RegisterPickup = 5;
        public int RegisterQuery = 6;
        public int CheckAndPay = 7;
        public int ReturnCashier = 8;

        #endregion
    }

}
