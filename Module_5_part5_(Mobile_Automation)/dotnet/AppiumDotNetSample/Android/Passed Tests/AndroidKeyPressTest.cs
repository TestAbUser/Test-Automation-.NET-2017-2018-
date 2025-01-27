﻿using Appium.Samples.Helpers;
using NUnit.Framework;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Appium.Android.Enums;
using OpenQA.Selenium.Remote;
using System;

namespace Appium.Samples.Android
{
    [TestFixture]
    class AndroidKeyPressTest
    {
        private AndroidDriver<AndroidElement> driver;

        [SetUp]
        public void BeforeAll()
        {
            DesiredCapabilities capabilities = Env.isSauce() ?
                Caps.getAndroid501Caps(Apps.get("androidApiDemos")) :
                Caps.getAndroid19Caps(Apps.get("androidApiDemos"));
            if (Env.isSauce())
            {
                capabilities.SetCapability("username", Env.getEnvVar("SAUCE_USERNAME"));
                capabilities.SetCapability("accessKey", Env.getEnvVar("SAUCE_ACCESS_KEY"));
                capabilities.SetCapability("name", "android - simple");
                capabilities.SetCapability("tags", new string[] { "sample" });
            }
            Uri serverUri = Env.isSauce() ? AppiumServers.sauceURI : AppiumServers.LocalServiceURIAndroid;
            driver = new AndroidDriver<AndroidElement>(serverUri, capabilities, Env.INIT_TIMEOUT_SEC);
            driver.Manage().Timeouts().ImplicitWait=(Env.IMPLICIT_TIMEOUT_SEC);
        }

        [SetUp]
        public void SetUp()
        {
            if (driver != null)
            {
                driver.ResetApp();
            }
        }

        [TearDown]
        public void AfterAll()
        {
            if (driver != null)
            {
                driver.Quit();
            }
            if (!Env.isSauce())
            {
                AppiumServers.StopLocalService();
            }
        }

        [Test]
        public void PressKeyCodeTest()
        {
            driver.PressKeyCode(AndroidKeyCode.Home);
        }

        [Test]
        public void PressKeyCodeWithMetastateTest()
        {
            driver.PressKeyCode(AndroidKeyCode.Space, AndroidKeyMetastate.Meta_Shift_On);
        }

        [Test]
        public void LongPressKeyCodeTest()
        {
            driver.LongPressKeyCode(AndroidKeyCode.Home);
        }

        [Test]
        public void LongPressKeyCodeWithMetastateTest()
        {
            driver.LongPressKeyCode(AndroidKeyCode.Space, AndroidKeyMetastate.Meta_Shift_On);
        }
    }
}
