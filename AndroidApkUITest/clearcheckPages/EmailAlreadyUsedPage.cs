using System;
using Xamarin.UITest;

/// <summary>
/// Authorization page.
/// Created by: José Carvajal
/// Date: 08/09/2015
///</summary>

namespace Clearcheck
{
	public class EmailAlreadyUsedPage : BasePage
	{
		readonly string yesAddButton;
		readonly string noAddButton;
		readonly string contactUsButton;

		public EmailAlreadyUsedPage (IApp app, Platform platform)
			: base(app, platform, "btnAddToExistingProfile", null)
		{
			if (onAndroid)
			{
				yesAddButton = "btnAddToExistingProfile";
				noAddButton = "btnReenterEmail";
				contactUsButton = "btnContactUs2";
			}
		}

		public void TapYesAddButton()
		{
			WaitForElement (yesAddButton);
			app.Tap (yesAddButton);
		}

		public void TapNoAddButton()
		{
			WaitForElement (noAddButton);
			app.Tap (noAddButton);
		}

		public void TaContactUsButton()
		{
			WaitForElement (contactUsButton);
			app.Tap (contactUsButton);
		}
	}
}

