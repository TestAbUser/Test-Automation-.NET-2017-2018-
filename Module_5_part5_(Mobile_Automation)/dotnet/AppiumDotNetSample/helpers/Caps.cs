﻿using System;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Remote;

namespace Appium.Samples.Helpers
{
	public class Caps
	{
		public static DesiredCapabilities getIos92Caps (string app) {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "9.2");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "iPhone Simulator");
            capabilities.SetCapability(MobileCapabilityType.App, app);
            return capabilities;
        }

		public static DesiredCapabilities getAndroid501Caps (string app) {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "5.0.1");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "Android Emulator");
            capabilities.SetCapability(MobileCapabilityType.App, app);
            return capabilities;
        }

		public static DesiredCapabilities getAndroid19Caps (string app) {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "");
            capabilities.SetCapability(AndroidMobileCapabilityType.AppPackage, "io.appium.android.apis");
            capabilities.SetCapability(AndroidMobileCapabilityType.AppWaitActivity, ".ApiDemos");
            // capabilities.SetCapability(AndroidMobileCapabilityType.AppWaitActivity, ".accessibility.AccessibilityNodeProviderActivity");
            // capabilities.SetCapability(AndroidMobileCapabilityType.AppActivity, ".accessibility.AccessibilityNodeProviderActivity");
             capabilities.SetCapability(AndroidMobileCapabilityType.AppActivity, ".ApiDemos");
            capabilities.SetCapability("avd", "New_Device_API_28");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "9");//"4.4.2");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "Android SDK built for x86");//"Android Emulator");
            capabilities.SetCapability(MobileCapabilityType.App, app);
            return capabilities;
        }

		public static DesiredCapabilities getSelendroid16Caps (string app) {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability(CapabilityType.BrowserName, "");
            capabilities.SetCapability(MobileCapabilityType.PlatformVersion, "4.4.2");
            capabilities.SetCapability(MobileCapabilityType.AutomationName, "selendroid");
            capabilities.SetCapability(MobileCapabilityType.DeviceName, "Android Emulator");
            capabilities.SetCapability(MobileCapabilityType.App, app);
            return capabilities;
        }
	}
}

