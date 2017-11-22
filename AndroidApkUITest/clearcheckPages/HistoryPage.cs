using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Text.RegularExpressions;
using System.Linq;

// <summary>
/// History page. This page appears when repair order sending is completed.
/// Created by: José Carvajal
/// Date: 09/28/2015
///</summary>
/// 

namespace Clearcheck
{
	public class HistoryPage : BasePage
	{
		readonly string statusLabel;

		public HistoryPage (IApp app, Platform platform)
			: base(app, platform,"lblStatus", null)
		{
			if (onAndroid)
			{
				statusLabel = "lblStatus";
			}
		}
	}
}

