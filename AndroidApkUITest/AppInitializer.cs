using System.Linq;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Android;
using Xamarin.UITest.Queries;

namespace Clearcheck
{
    //[TestFixture]
    public class AppInitializer
    {
        //[SetUp] //setup the test
        public static IApp StartApp (Platform platform)
		{
			// TODO: If the iOS or Android app being tested is included in the solution 
			// then open the Unit Tests window, right click Test Apps, select Add App Project
			// and select the app projects that should be tested.
			if (platform == Platform.Android) {
				return ConfigureApp
					.Android
					// TODO: Update this path to point to your Android app and uncomment the
					// code if the app is not included in the solution.
					//.ApkFile ("../../../Droid/bin/Debug/xamarinforms.apk")
					//.ApkFile(@"../../Resources/com.clearcheck.cmbeta-3.02.01.apk")
                         .ApkFile(@"../../Resources/flipkart.apk")                         
                         .StartApp ();
			}

			return ConfigureApp
				.iOS

				// TODO: Update this path to point to your iOS app and uncomment the
				// code if the app is not included in the solution.
				//.AppBundle ("../../../iOS/bin/iPhoneSimulator/Debug/XamarinForms.iOS.app")
				.StartApp ();
		}
	}
}