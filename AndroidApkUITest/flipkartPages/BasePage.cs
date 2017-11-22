using System;
using NUnit.Framework;
using Xamarin.UITest;
using Xamarin.UITest.Queries;

// <summary>
/// Base Page
/// Created by: José Carvajal
/// Date: 09/28/2015
///</summary>
/// 
namespace Clearcheck
{
    public class BasePage
    {
        protected readonly IApp app;
        protected readonly bool onAndroid;
        protected readonly bool oniOS;

        protected BasePage(IApp app, Platform platform)
        {
            this.app = app;

            onAndroid = platform == Platform.Android;
            oniOS = platform == Platform.iOS;
        }

        protected BasePage(IApp app, Platform platform, Func<AppQuery, AppQuery> androidTrait, Func<AppQuery, AppQuery> iOSTrait) : this(app, platform)
        {
            if (onAndroid)
                app.WaitForElement(androidTrait, "Time out waiting for element:" + androidTrait, new TimeSpan(0, 0, 3, 0, 0));
            if (oniOS)
                app.WaitForElement(iOSTrait, "Time out waiting for element:" + iOSTrait, new TimeSpan(0, 0, 3, 0, 0));

            app.Screenshot("On " + this.GetType().Name);
        }

        protected BasePage(IApp app, Platform platform, string androidTrait, string iOSTrait) : this(app, platform, x => x.Marked(androidTrait), x => x.Marked(iOSTrait))
        {

        }

        /// <summary>
        /// Wait for element generic. 
        /// </summary>
        /// <param name="element">Element name as string</param>
        public void WaitForElement(string element)
        {

            app.WaitForElement(element, "Time out waiting for element: " + element, new TimeSpan(0, 0, 3, 0, 0));
        }

        /// Wait for element is not present in the screen. 
        /// </summary>
        /// <param name="element">Element name as string</param>
        public void WaitForElementNotPresent(string element)
        {

            app.WaitForNoElement(element, "Time out waiting for element not present: " + element, new TimeSpan(0, 0, 3, 0, 0));
        }

        /// <summary>
        /// Scrolls down until element appears.
        /// </summary>
        /// <param name="element">Element.</param>
        public void scrollDownUntilElementAppears(string element)
        {

            app.ScrollTo(element);
        }
    }
}