using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;
using System.Threading;


using System.Text;

namespace Clearcheck
{
	[TestFixture(Platform.Android)]
	//[TestFixture (Platform.iOS)]
	public class BaseTest
	{
		public IApp app;
		public Platform platform;

		//Repair shop credentials
		public string rONumber;
		public string userName = "Xamarin";
		public string shopName = "ClearCheck QA UAT";
		public string email = "Xamarin";

		public string itemName = '"' + "BAT" + '"' + " Terminal";

		public BaseTest ()
		{
		}

		[SetUp] //setup the test
		public void BeforeEachTest()
		{
			app = AppInitializer.StartApp(platform);
			rONumber = RandomString (15);
		}

		/// <summary>
		/// Generates a random numeric string with the given length
		/// </summary>
		/// <param name="size">String size wanted</param>
		/// <returns>Random string</returns>
		public string RandomString(int size)
		{
			StringBuilder builder = new StringBuilder();
			Random random = new Random();
			string source = "0123456789";
			char ch ;
			for(int i=0; i<size; i++)
			{
				int r = random.Next (10);
				ch = source [r];
				builder.Append(ch); 
			}

			return builder.ToString();
		}



	}
}

