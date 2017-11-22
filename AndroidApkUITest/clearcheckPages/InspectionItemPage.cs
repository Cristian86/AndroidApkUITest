using System;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Text.RegularExpressions;
using System.Linq;

// <summary>
/// Inspection Item Page.
/// Created by: José Carvajal
/// Date: 09/28/2015
///</summary>
/// 
namespace Clearcheck
{
	public class InspectionItemPage : BasePage
	{
		//Select item page elements
		readonly string backButton;
		readonly string doneButton;
		readonly string photoIcon;
		readonly string searchInspectionItemTextBox;
		readonly string inspectionItem;
		readonly string typesLoadingProgressBar;

		//Cammera usage elements
		readonly string takePhotoButton;
		readonly string usePhotoButton;
		readonly string cancelPhotoButton;

		public InspectionItemPage (IApp app, Platform platform)
			: base(app, platform, "content", null)
		{
			if (onAndroid)
			{
				backButton = "btnBack";
				doneButton = "btnDone";
				searchInspectionItemTextBox = "txtSearchFilter";
				inspectionItem = "lblHeader";
				typesLoadingProgressBar = "rlInspectionItemsProgressBar";

				//Cammera elements
				takePhotoButton = "btnTakePhoto";
				usePhotoButton = "btnOK";
				cancelPhotoButton = "btnCancel";
			}
		}

		public InspectionItemPage SwipeLeftItem(string itemName){
			//To do
			return this;
		}

		public InspectionItemPage SwipeRightItem(string itemName){
			//To do
			return this;
		}

		//user selects take photo icon
		public InspectionItemPage TapPhotoIcon(string itemName){
			//to do
			return this;
		}

		//user click on Done to finihs upload files, photos or videos
		public InspectionItemPage TapDoneButton(){

			WaitForElement(doneButton);
			app.Tap (doneButton);
			return this;
		}

		public InspectionItemPage TapItem(string itemName){

			WaitForElementNotPresent (typesLoadingProgressBar);
			app.ScrollDownTo (c => c.Id (inspectionItem).Text (itemName));
			app.Tap (c => c.Id(inspectionItem).Text(itemName));
			app.Screenshot ("User taps item");
			return this;
		}

		/// <summary>
		/// Cammera Usage methods from here
		/// </summary>

		//User clicks Use Button
		public InspectionItemPage TapUseButton(){

			WaitForElement (usePhotoButton);
			app.Tap (usePhotoButton);
			return this;
		}

		//user take photo in the cammera page
		public InspectionItemPage TakePhoto(){

			WaitForElement (takePhotoButton);
			app.Tap (takePhotoButton);
			app.Screenshot ("User takes photo");
			return this;
		}

		//user don't take photo and go out of cammera page
		public InspectionItemPage TapCancelButton(){

			WaitForElement (cancelPhotoButton);
			app.Tap (cancelPhotoButton);
			app.Screenshot ("User cancel photo");
			return this;
		}
	}
}