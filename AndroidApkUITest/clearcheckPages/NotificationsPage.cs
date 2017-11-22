using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Text.RegularExpressions;
using System.Linq;

// <summary>
/// Notification Page. This page appears when user send an inspection order.
/// Created by: José Carvajal
/// Date: 09/28/2015
///</summary>
/// 
/// 
namespace Clearcheck
{
	public class NotificationsPage : BasePage
	{
		readonly string sendButton;

		public NotificationsPage (IApp app, Platform platform)
			: base(app, platform, "btnNext", null)
		{
			if (onAndroid)
			{
				sendButton = "btnNext";
			}
		}

		public NotificationsPage TapSendButton()
		{
			WaitForElement (sendButton);
			app.Tap (sendButton);
			return this;
		}
	}
}

