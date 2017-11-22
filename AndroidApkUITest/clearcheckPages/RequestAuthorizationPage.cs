using System;
using Xamarin.UITest;

/// <summary>
/// Authorization page.
/// Created by: José Carvajal
/// Date: 08/09/2015
///</summary>
/// 
namespace Clearcheck
{
	public class RequestAuthorizationPage : BasePage
	{
		readonly string requestButton;

		public RequestAuthorizationPage(IApp app, Platform platform)
			: base(app, platform, "vwNonAuthenticatedPanel", null)
		{
			if (onAndroid)
			{
				requestButton = "vwNonAuthenticatedPanel";
			}
		}

		public void RequestAuthorization()
		{
			WaitForElement (requestButton);
			app.Tap(requestButton);
			app.Screenshot("Requesting authorization");
		}
	}
}

