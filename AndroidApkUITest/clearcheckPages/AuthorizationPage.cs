using Xamarin.UITest;
using System;

/// <summary>
/// Authorization page.
/// Created by: José Carvajal
/// Date: 08/09/2015
///</summary>

namespace Clearcheck
{
	public class AuthorizationPage : BasePage
	{
		readonly string nameField;
		readonly string dealerField;
		readonly string emailField;
		readonly string agreementCheck;
		readonly string sendButton;

		public AuthorizationPage(IApp app, Platform platform)
			: base(app, platform, "txtDialerOrShopName", null)
		{
			if (onAndroid)
			{
				nameField = "inputName";
				dealerField = "inputInitials";
				emailField = "inputEmail";
				agreementCheck = "cbxAgreement";
				sendButton = "btnContinue";
			}
		}

		public AuthorizationPage EnterInfo(string name, string dealer, string email)
		{
			app.EnterText(nameField, name);
			app.EnterText(dealerField, dealer);
			scrollDownUntilElementAppears (emailField);
			app.EnterText(emailField, email);

			app.Screenshot("Info entered");
			return this;
		}

		public AuthorizationPage Agree()
		{
			scrollDownUntilElementAppears (agreementCheck);
			app.Tap(agreementCheck);
			app.Screenshot("Agreed");

			return this;
		}

		public AuthorizationPage Send()
		{
			WaitForElement (sendButton);
			app.Tap(sendButton);
			app.Screenshot("Sent");

			return this;
		}
	}
}