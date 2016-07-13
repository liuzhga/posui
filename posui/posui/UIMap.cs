namespace posui
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

        /// <summary>
        /// login - 使用“loginParams”将参数传递到此方法中。
        /// </summary>
        public void login()
        {
            #region Variable Declarations

            WinEdit uIcodeEdit = this.UI收银员登录Window.UI收银员子Window.收银员编码;
            WinEdit uIsecWinEdit = this.UI收银员登录Window.UI收银员登录子Window1.收银员密码;

            #endregion

            // 启动“%ProgramFiles%\Chanjet\Pos\ufida_t_pos_app.exe”
            ApplicationUnderTest ufida_t_pos_appApplication = ApplicationUnderTest.Launch(this.loginParams.ExePath,
                this.loginParams.AlternateExePath);

            // 在 文本框 中键入“1”
            uIcodeEdit.Text = this.loginParams.UISendOne;

            // 在 文本框 中键入“{Enter}”
            Keyboard.SendKeys(uIcodeEdit, this.loginParams.UISendEnter, ModifierKeys.None);

            // 在 文本框 中键入“{Enter}”
            Keyboard.SendKeys(uIsecWinEdit, this.loginParams.UISendEnter, ModifierKeys.None);
        }



        public void OnDuty()
        {
            #region Variable Declarations

            WinEdit uIOnDuty = this.UI主菜单选择Window.主菜单选择.当班;
            WinComboBox uI班次选择控件 = this.UI当班Window1.UI当班子Window.UI班次选择控件;
            WinClient uI提示信息Client = this.UI确定当班提示信息Window.UI确定当班提示信息Client;

            WinClient uI畅捷通T零售POS软件Client = this.UI畅捷通T零售POS软件Window.UI畅捷通T零售POS软件Client;

            #endregion

            // 在 文本框 中键入“{Enter}”
            Keyboard.SendKeys(uIOnDuty, this.loginParams.UISendEnter, ModifierKeys.None);


            // 在 组合框 中选择“晚班                                                                                                    1650”
            uI班次选择控件.SelectedItem = this.loginParams.UIComboBoxSelectedNight;

            // 在 组合框 中键入“{Enter}”
            Keyboard.SendKeys(uI班次选择控件, this.loginParams.UISendEnter, ModifierKeys.None);

            // 在 “当班提示信息” 客户端 中键入“{Enter}”
            Keyboard.SendKeys(uI提示信息Client, this.loginParams.UISendEnter, ModifierKeys.None);

        }
    }
    /// <summary>
    /// 要传递到“login”中的参数
    /// </summary>
    [GeneratedCode("编码的 UI 测试生成器", "14.0.23107.0")]
    public class loginParams
    {

        #region Fields

        /// <summary>
        /// 启动“%ProgramFiles%\Chanjet\Pos\ufida_t_pos_app.exe”
        /// </summary>
        public string ExePath = "C:\\Program Files (x86)\\Chanjet\\Pos\\ufida_t_pos_app.exe";

        /// <summary>
        /// 启动“%ProgramFiles%\Chanjet\Pos\ufida_t_pos_app.exe”
        /// </summary>
        public string AlternateExePath = "%ProgramFiles%\\Chanjet\\Pos\\ufida_t_pos_app.exe";

        /// <summary>
        /// 在 文本框 中键入“1”
        /// </summary>
        public string UISendOne = "1";

        /// <summary>
        /// 在 文本框 中键入“{Enter}”
        /// </summary>
        public string UISendEnter = "{Enter}";

        public string UIComboBoxSelectedMorning = "早班                                                                               " +
    "                     1648";
        public string UIComboBoxSelectedMid = "中班                                                                               " +
    "                     1649";

        public string UIComboBoxSelectedNight = "晚班                                                                               " +
    "                     1650";

        #endregion
    }
}
