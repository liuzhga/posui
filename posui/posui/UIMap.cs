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

        /// <summary>
        /// login - 使用“loginParams”将参数传递到此方法中。
        /// </summary>
        public void login()
        {
            #region Variable Declarations
            WinEdit uIItemEdit = this.UI收银员登录Window.UIItemWindow.收银员编码;
            WinEdit uIItemEdit1 = this.UI收银员登录Window.UIItemWindow1.收银员密码;
            #endregion

            // 启动“%ProgramFiles%\Chanjet\Pos\ufida_t_pos_app.exe”
            ApplicationUnderTest ufida_t_pos_appApplication = ApplicationUnderTest.Launch(this.loginParams.ExePath, this.loginParams.AlternateExePath);

            // 在 文本框 中键入“1”
            uIItemEdit.Text = this.loginParams.UISendOne;

            // 在 文本框 中键入“{Enter}”
            Keyboard.SendKeys(uIItemEdit, this.loginParams.UISendEnter, ModifierKeys.None);

            // 在 文本框 中键入“{Enter}”
            Keyboard.SendKeys(uIItemEdit1, this.loginParams.UISendEnter, ModifierKeys.None);
        }

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

        /// <summary>
        /// 在 文本框 中键入“{Enter}”
        /// </summary>
        //public string UIItemEditSendKeys1 = "{Enter}";
        #endregion
    }
}
