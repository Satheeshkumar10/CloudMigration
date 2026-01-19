
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
            Thread.Sleep(2000);
            TakeAndCompareScreenshot("name_1");
        }  
		[Test]
        [Category("name property")]
        public void name_12()
        {
            Basicsbutton();
            App.ClearText("name");
            App.EnterText("name", "SfButton");
            App.DismissKeyboard();
            Thread.Sleep(2000);
            TakeAndCompareScreenshot("name_12");
        }
        #endregion
    }
}
