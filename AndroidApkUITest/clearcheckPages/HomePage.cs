using System;
using Xamarin.UITest;
using Query = System.Func<Xamarin.UITest.Queries.AppQuery, Xamarin.UITest.Queries.AppQuery>;

/// <summary>
/// Home page.
/// Created by: José Carvajal
/// Date: 08/09/2015
///</summary>

namespace Clearcheck
{
	public class HomePage : BasePage
	{
		readonly string fullInspectionButton;
		readonly string singleInspectionButton;
		readonly Query historyTabButton;

		public HomePage(IApp app, Platform platform)
			: base(app, platform, "ClearMechanic", null)
		{
			if (onAndroid)
			{
				fullInspectionButton = "btnFullInspection";
				singleInspectionButton = "btnSingleItem";
				historyTabButton = x => x.Id("tabs").Descendant(8);
			}
		}

		public void SelectFullInspection()
		{
			WaitForElement(fullInspectionButton);
			app.Tap(fullInspectionButton);
		}

		public void SelectSingleInspection()
		{
			WaitForElement(singleInspectionButton);
			app.Tap(singleInspectionButton);
		}

		public void SelectHistory()
		{
			app.Tap(historyTabButton);
		}
	}
}

