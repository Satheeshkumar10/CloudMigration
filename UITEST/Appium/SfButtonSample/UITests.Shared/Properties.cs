using NUnit.Framework;
using UITests.Shared;
using Syncfusion.UITestHelpers.Appium;
using Syncfusion.UITestHelpers.Core;
using Syncfusion.UITestHelpers.Screenshot;

namespace SfButtonScripts
{
	#if ANDROID
    [TestFixture(TestDevice.Android)]
    #elif IOS
    [TestFixture(TestDevice.iOS)]
    #elif MACOS
    [TestFixture(TestDevice.Mac)]
    #elif WINDOWS
    [TestFixture(TestDevice.Windows)]
    #endif
    public class Properties : BaseTest
    {
        public Properties(TestDevice testDevice) : base(testDevice)
        {
        }
        [TearDown]
        public void TearDown()
        {
            Reset(); // Reset App each and evry test
        }
        #region Features
        [Test]
        [Category("name property")]

        public void name_1()
        {
            Basicsbutton("Features");
            //App.Tap("name");
            App.ClearText("name");
            App.EnterText("name", "SfButton");
            App.DismissKeyboard();
            Thread.Sleep(2000); TakeAndCompareScreenshot("name_1");
        }
        [Test]
        [Category("text color property")]

        public void textcolor_1()
        {
            Basicsbutton("Features");
            App.Tap("TextColor");

#if ANDROID || WINDOWS || MACOS
            App.Tap("Green");
#else
            App.iOSPickerInteract("TextColor","Green");
#endif
            Thread.Sleep(2000); TakeAndCompareScreenshot("textcolor_1");
        }
        [Test]
        [Category("text color property")]

        public void textcolor_2()
        {
            Basicsbutton("Features");
            App.Tap("TextColor");
#if ANDROID || WINDOWS || MACOS
            App.Tap("Black");
#else
            App.iOSPickerInteract("TextColor","Black");
#endif
            Thread.Sleep(2000); TakeAndCompareScreenshot("textcolor_2");
        }
        [Test]
        [Category("text color property")]

        public void textcolor_3()
        {
            Basicsbutton("Features");
            App.Tap("TextColor");
#if ANDROID || WINDOWS || MACOS
            App.Tap("Yellow");
#else
            App.iOSPickerInteract("TextColor","Yellow");
#endif
            Thread.Sleep(2000); TakeAndCompareScreenshot("textcolor_3");
        }
        [Test]
        [Category("text color property")]

        public void textcolor_4()
        {
            Basicsbutton("Features");
            App.Tap("TextColor");
#if ANDROID || WINDOWS || MACOS
            App.Tap("Orange");
#else
            App.iOSPickerInteract("TextColor","Orange");
#endif
            Thread.Sleep(2000); TakeAndCompareScreenshot("textcolor_4");
        }
        [Test]
        [Category("text color property")]

        public void textcolor_5()
        {
            Basicsbutton("Features");
            App.Tap("TextColor");
#if ANDROID || WINDOWS || MACOS
            App.Tap("Blue");
#else
            App.iOSPickerInteract("TextColor","Blue");
#endif
            Thread.Sleep(2000); TakeAndCompareScreenshot("textcolor_5");
        }
        [Test]
        [Category("show icon property")]

        public void showicon_1()
        {
            Basicsbutton("Features");
            App.Tap("ShowIcon");
            Thread.Sleep(2000); TakeAndCompareScreenshot("showicon_1");
        }
    }

    #endregion
}