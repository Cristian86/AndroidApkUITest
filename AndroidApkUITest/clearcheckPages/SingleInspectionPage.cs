using System;
using NUnit.Framework;
using Xamarin.UITest;
using System.Linq;
using Xamarin.UITest.Queries;
using System.Text.RegularExpressions;

// <summary>
/// Authorization page.
/// Created by: José Carvajal
/// Date: 08/09/2015
///</summary>

namespace Clearcheck
{
	public class SingleInspectionPage : BasePage
	{
		readonly string typeROHint;
		readonly string inspectionItemButton;
		readonly string sendButton;
		readonly string doneNumericButton;


		public SingleInspectionPage (IApp app, Platform platform)
			: base(app, platform, "pnlContent", null)
		{
			if (onAndroid)
			{
				typeROHint = "hintRepairOrderNumber";
				inspectionItemButton = "btnNext";
				sendButton = "btnSend";
				doneNumericButton = "Done"; 
			}
		}

		public SingleInspectionPage EnterRONumber(String roNumber){

			/*Arrange*/
			string[] numbers;

			/*Act*/
			WaitForElementNotPresent ("rlInspectionItemsProgressBar");
			app.Tap (typeROHint);
		    numbers = Regex.Split(roNumber, string.Empty);

			foreach (string n in numbers)
			{
				app.Tap(n);
			}
			app.Screenshot("RO Number Added");

			/*Assert*/
			/*AppResult[] result = app.Query(c => c.Id(typeROHint).Text("RO #" + roNumber));
			Assert.IsTrue(result.Any(), "RO #" + roNumber);*/

			return this;
		}

		public SingleInspectionPage TapInspectionItemButton()
		{
			WaitForElement(inspectionItemButton);
			app.Tap (inspectionItemButton);
			return this;
		}

		public SingleInspectionPage TapSendButton()
		{
			WaitForElement(sendButton);
			app.Tap (sendButton);
			return this;
		}
	}
}