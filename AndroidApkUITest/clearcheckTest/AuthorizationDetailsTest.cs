using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;

/// <summary>
/// Authorization details test.
/// Created by: Jose Carvajal
/// Date: 08/11/2015
/// </summary>

namespace Clearcheck
{
	public class AuthorizationDetailsTest : BaseTest
	{

		public AuthorizationDetailsTest (Platform platform)
		{
			this.platform = platform;
		}

		//[Test]
		[Category("Basic")]
		public void UserSuccessLogin(){

			new RequestAuthorizationPage(app, platform)
				.RequestAuthorization();

			new AuthorizationPage(app, platform)
				.EnterInfo(userName, shopName, email)
				.Agree()
				.Send();

			new EmailAlreadyUsedPage (app, platform)
				.TapYesAddButton ();

			new HomePage (app, platform);
		}
	}
}