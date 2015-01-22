using System;
using System.Collections.Generic;
using System.Linq;

using Foundation;
using UIKit;
using Xamarin.Forms;

namespace KidozenBlankProject.iOS
{
	[Register ("AppDelegate")]
	public partial class AppDelegate : UIApplicationDelegate
	{
		UIWindow window;

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			global::Xamarin.Forms.Forms.Init ();

			window = new UIWindow(UIScreen.MainScreen.Bounds);

			window.RootViewController = App.GetLoginPage().CreateViewController();

			window.MakeKeyAndVisible();

			return true;
		}
	}
}

