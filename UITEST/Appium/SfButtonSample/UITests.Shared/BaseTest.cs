using NUnit.Framework;
using Syncfusion.UITestHelpers.Appium;
using Syncfusion.UITestHelpers.Core;
using OpenQA.Selenium.Appium;
using Syncfusion.UITestHelpers.NUnit;
using Syncfusion.UITestHelpers.Screenshot;
using Syncfusion.UITestHelpers.ExtendReport;
using OpenQA.Selenium;

namespace UITests.Shared
{
    // NOTE: Do NOT put [TestFixture] on abstract classes.
    public abstract class BaseTest : UITestData
    {
        // Keep the existing parameterized ctor for flexibility (optional)
        public BaseTest(TestDevice testDevice) : base(testDevice) { }

        // NEW: parameterless constructor selects the device by target platform
        protected BaseTest() : base(
        #if ANDROID
            TestDevice.Android
        #elif IOS
            TestDevice.iOS
        #elif MACOS
            TestDevice.Mac
        #elif WINDOWS
            TestDevice.Windows
        #else
            TestDevice.Android // default fallback
        #endif
        )
        {
        }

        public override IConfig GetTestConfig()
        {
            reportpath();
            var config = new Config();

            var appIdentifierKey = "AppId";
            var appIdentifier = "com.companyname.SfButtonSample";
            var AppMain1 = "AppMain";
            var AppMain12 = "crc6443b590b4b829944e";

            config.SetProperty(appIdentifierKey, appIdentifier);
            config.SetProperty(AppMain1, AppMain12);

            if (_testDevice == TestDevice.Windows)
            {
                var appIdentifierKey11 = "AppName";
                var appIdentifier1 = "SfButtonSample";
                config.SetProperty(appIdentifierKey11, appIdentifier1);
            }

            var appIdFromEnv = Environment.GetEnvironmentVariable("APPID");
            if (!string.IsNullOrWhiteSpace(appIdFromEnv))
            {
                config.SetProperty(appIdentifierKey, appIdFromEnv);
            }

            if (_testDevice == TestDevice.Mac)
            {
                config.SetProperty("MacApp", "SfButtonSample");
            }

            if (_testDevice == TestDevice.iOS)
            {
                config.SetProperty("iOSAppName", "com.companyname.SfButtonSample");

                var simId = Environment.GetEnvironmentVariable("SIMID");
                if (!string.IsNullOrWhiteSpace(simId))
                {
                    config.SetProperty("Udid", simId);
                }
                else
                {
                    config.SetProperty("DeviceName", "iPhone 13");
                    config.SetProperty("PlatformVersion", "15.2");
                }
            }

            return config;
        }

        public void TakeAndCompareScreenshot(string filename)
        {
        #if ANDROID
            var screenshotHelper = new AndroidScreenshotHelper(App);
            screenshotHelper.TakeAndCompareScreenshots(filename);
        #elif WINDOWS
            var screenshotHelper = new WindowsScreenshotHelper(App);
            screenshotHelper.TakeAndCompareScreenshots(filename);
        #elif IOS
            var screenshotHelper = new iOSScreenshotHelper(App);
            screenshotHelper.TakeAndCompareScreenshots(filename);
        #elif MACOS
            var screenshotHelper = new MacScreenshotHelper(App);
            screenshotHelper.TakeAndCompareScreenshots(filename);
        #endif
        }

        public void reportpath()
        {
        #if WINDOWS
            DataBridge.report = @"..\..\..\report";
            DataBridge.htmlhomepage = @"..\..\..\report\home.html";
            DataBridge.htmldashbard = @"..\..\..\report\dashboard.html";
            DataBridge.updateStats = @"..\..\..\report\updateStats.js";
        #elif ANDROID || IOS || MACOS
            DataBridge.report = @"../../../report";
            DataBridge.htmlhomepage = @"../../../report/home.html";
            DataBridge.htmldashbard = @"../../../report/dashboard.html";
            DataBridge.updateStats = @"../../../report/updateStats.js";
        #endif
        }

        // Common helpers
        public void Basicsbutton(string filename)
        {
            App.WaitForElement("Home", timeout: TimeSpan.FromSeconds(50));
            App.EnterText("editor", filename); 
            App.WaitForElement("Home", timeout: TimeSpan.FromSeconds(50));
            App.Tap("btn");
            Thread.Sleep(5000);
            App.WaitForElement("Features", timeout: TimeSpan.FromSeconds(50));
        }

        // Strongly recommended to ensure runner cleanup
        [OneTimeTearDown]
        public void GlobalTearDown()
        {
            try
            {
                // If UITestData/App holds driver/session handles, ensure proper dispose/quit here.
                // Example:
                // App?.Quit();  // or driver?.Quit();
            }
            catch { /* swallow */ }
        }
    }
}
