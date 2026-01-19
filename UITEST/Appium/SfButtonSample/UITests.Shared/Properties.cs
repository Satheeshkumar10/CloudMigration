
using NUnit.Framework;
using UITests.Shared;
using Syncfusion.UITestHelpers.Appium;
using Syncfusion.UITestHelpers.Core;
using Syncfusion.UITestHelpers.Screenshot;

namespace SfButtonScripts
{
    // [TestFixture] attribute is optional; NUnit infers from [Test] methods.
    // You can add [TestFixture] without arguments if you prefer to be explicit.
    [TestFixture]
    public class Properties : BaseTest
    {
        // NO constructor — now NUnit can construct it (parameterless via BaseTest).

        [TearDown]
        public void TearDown()
        {
            Reset(); // Reset App each and every test
        }

        #region Features

        [Test]
        [Category("name property")]
        public void name_1()
        {
            Basicsbutton();
            App.ClearText("name");
            App.EnterText("name", "SfButton");
            App.DismissKeyboard();
            Thread.Sleep(2000);
            TakeAndCompareScreenshot("name_1");
        }

        [Test]
        [Category("text color property")]
        public void textcolor_1()
        {
            Basicsbutton();
            App.Tap("TextColor");
        #if ANDROID || WINDOWS || MACOS
            App.Tap("Green");
        #else
            App.iOSPickerInteract("TextColor", "Green");
        #endif
            Thread.Sleep(2000);
            TakeAndCompareScreenshot("textcolor_1");
        }

        [Test]
        [Category("text color property")]
        public void textcolor_2()
        {
            Basicsbutton();
            App.Tap("TextColor");
        #if ANDROID || WINDOWS || MACOS
            App.Tap("Black");
        #else
            App.iOSPickerInteract("TextColor", "Black");
        #endif
            Thread.Sleep(2000);
            TakeAndCompareScreenshot("textcolor_2");
        }

        [Test]
        [Category("text color property")]
        public void textcolor_3()
        {
            Basicsbutton();
            App.Tap("TextColor");
        #if ANDROID || WINDOWS || MACOS
            App.Tap("Yellow");
        #else
            App.iOSPickerInteract("TextColor", "Yellow");
        #endif
            Thread.Sleep(2000);
            TakeAndCompareScreenshot("textcolor_3");
        }

        [Test]
        [Category("text color property")]
        public void textcolor_4()
        {
            Basicsbutton();
            App.Tap("TextColor");
        #if ANDROID || WINDOWS || MACOS
            App.Tap("Orange");
        #else
            App.iOSPickerInteract("TextColor", "Orange");
        #endif
            Thread.Sleep(2000);
            TakeAndCompareScreenshot("textcolor_4");
        }

        [Test]
        [Category("text color property")]
        public void textcolor_5()
        {
            Basicsbutton();
            App.Tap("TextColor");
        #if ANDROID || WINDOWS || MACOS
            App.Tap("Blue");
        #else
            App.iOSPickerInteract("TextColor", "Blue");
        #endif
            Thread.Sleep(2000);
            TakeAndCompareScreenshot("textcolor_5");
        }

        [Test]
        [Category("show icon property")]
        public void showicon_1()
        {
            Basicsbutton();
            App.Tap("ShowIcon");
            Thread.Sleep(2000);
            TakeAndCompareScreenshot("showicon_1");
        }

        #endregion
    }
}
