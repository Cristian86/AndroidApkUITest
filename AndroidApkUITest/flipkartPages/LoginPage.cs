using System;
using Xamarin.UITest;

namespace Clearcheck
{
    public class LoginPage : BasePage
    {
        readonly string title_text_id;
        readonly string mobileNo;
        readonly string flyout_parent_title;
        readonly string logo_icon;
        readonly string passwordTextBox;
        readonly string btn_mlogin;
        readonly string btn_msignup;



        public LoginPage(IApp app, Platform platform) : base(app, platform, "title_text_id", null)
        {
            if (onAndroid)
            {
                mobileNo = "mobileNo";
                passwordTextBox = "et_password";
                btn_mlogin = "btn_mlogin";
                btn_msignup = "btn_msignup";
                logo_icon = "logo_icon";
                flyout_parent_title = "flyout_parent_title";
                title_text_id = "title_text_id";

            }
        }
        
        public LoginPage UserTapsMenu()
        {

            app.WaitForElement(title_text_id);
            app.Tap(logo_icon);

            return this;

        }


        public LoginPage UserTapsMyAccount()
        {

            app.WaitForElement(flyout_parent_title);
            //app.Tap(flyout_parent_title);
            app.Tap(x => x.Text("My Account"));

            return this;

        }


        public LoginPage UserEntersPhoneNumber(string phoneNumber)
        {
            app.ClearText(mobileNo);
            app.WaitForElement(mobileNo);
            app.EnterText(mobileNo, phoneNumber);

            return this;

        }
        public LoginPage UserEnterPassword(string password)
        {
            app.WaitForElement(passwordTextBox);
            app.EnterText(passwordTextBox, password);

            return this;

        }

        public LoginPage UserTapsSingUpButton()
        {

            app.WaitForElement(btn_mlogin);
            app.Tap(btn_mlogin);

            return this;

        }

    }
}
