using System;
using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

namespace Clearcheck
{
	public class SingleInspectionTest : BaseTest
	{

		public SingleInspectionTest (Platform platform)
		{
			this.platform = platform;
		}

		//[Test]
		[Category("Regression")]
		/// <summary>
		/// Verify if Repair order number is properly entered.
		/// </summary>
		public void UserAbleEnterRONumberByTypeRO()
		{
			new RequestAuthorizationPage(app, platform)
				.RequestAuthorization();
			
			new AuthorizationPage(app, platform)
				.EnterInfo(userName, shopName, email)
				.Agree()
				.Send();

			new EmailAlreadyUsedPage (app, platform)
				.TapYesAddButton ();

			new HomePage (app, platform)
				.SelectSingleInspection ();
			
			new SingleInspectionPage(app, platform)
				.EnterRONumber(rONumber);
	}

		//[Test]
		[Category("Smoke")]
		/// <summary>
		/// Users the able take single photo. In a single Inspection.
		/// </summary>
		public void UserAbleTakeSinglePhoto(){
			
			new RequestAuthorizationPage (app, platform)
				.RequestAuthorization ();

			new AuthorizationPage (app, platform)
				.EnterInfo (userName, shopName, email)
				.Agree ()
				.Send ();

			new EmailAlreadyUsedPage (app, platform)
				.TapYesAddButton ();

			new HomePage (app, platform)
				.SelectSingleInspection ();

			new SingleInspectionPage (app, platform)
				.EnterRONumber (rONumber)
				.TapInspectionItemButton ();
			
			new InspectionItemPage (app, platform)
				.TapItem (itemName)
				.TakePhoto ()
				.TapUseButton ();

			new SingleInspectionPage (app, platform);
		}

		//[Test]
		[Category("Smoke")]
		/// <summary>
		/// Users able to upload repair order with photo. Single Item.
		/// </summary>
		public void UserUploadRepairOrderWithoutPhoto(){

			new RequestAuthorizationPage (app, platform)
				.RequestAuthorization ();

			new AuthorizationPage (app, platform)
				.EnterInfo (userName, shopName, email)
				.Agree ()
				.Send ();

			new EmailAlreadyUsedPage (app, platform)
				.TapYesAddButton ();

			new HomePage (app, platform)
				.SelectSingleInspection ();

			new SingleInspectionPage (app, platform)
				.EnterRONumber (rONumber)
				.TapInspectionItemButton ();
			
			new InspectionItemPage (app, platform)
				.TapItem (itemName)
				.TapCancelButton ()
				.TapDoneButton ();

			new SingleInspectionPage (app, platform)
				.TapSendButton ();

			new NotificationsPage (app, platform)
				.TapSendButton ();

			new HistoryPage (app, platform);
		}

		//[Test]
		//[Category("Smoke")]
		/// <summary>
		/// Users able to upload repair order with photo. Single Item.
		/// </summary>
		public void UserUploadRepairOrderWithPhoto(){

			new RequestAuthorizationPage (app, platform)
				.RequestAuthorization ();

			new AuthorizationPage (app, platform)
				.EnterInfo (userName, shopName, email)
				.Agree ()
				.Send ();

			new EmailAlreadyUsedPage (app, platform)
				.TapYesAddButton ();

			new HomePage (app, platform)
				.SelectSingleInspection ();

			new SingleInspectionPage (app, platform)
				.EnterRONumber (rONumber)
				.TapInspectionItemButton ();

			new InspectionItemPage (app, platform)
				.TapItem (itemName)
				.TakePhoto ()
				.TapUseButton ();

			new SingleInspectionPage (app, platform)
				.TapSendButton ();

			new NotificationsPage (app, platform)
				.TapSendButton ();

			new HistoryPage (app, platform);
		}
	}
}