using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Clearcheck
{
    [TestFixture]
    public class LoginTest : BaseTest
    {
        public LoginTest(Platform platform)
		{
			this.platform = platform;
		}

        [Test]
        public void UserIsAbleToSingUp()
        {
            //app.Repl();
            new LoginPage(app, platform)
                .UserTapsMenu()
                .UserTapsMyAccount()
                .UserEntersPhoneNumber("(506)88439771")
                .UserEnterPassword("password")
                .UserTapsSingUpButton();
                //.UserTapsSingUpButton();           
        }
    }
}
