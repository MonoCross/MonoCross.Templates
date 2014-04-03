using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

using MonoCross.Navigation;
using MonoCross.Touch;

namespace $safeprojectname$
{
    public class Application
    {
        static void Main(string[] args)
        {
            UIApplication.Main(args, null, "AppDelegate");
        }
    }

    // The name AppDelegate is referenced in the MainWindow.xib file.

    [MXTouchTabletOptions(TabletLayout.SinglePane)]
    [MXTouchContainerOptions(SplashBitmap = "splash.png")]
    [Register("AppDelegate")]
    public partial class AppDelegate : UIApplicationDelegate
    {
        UIWindow _window;

        // This method is invoked when the application has loaded its UI and its ready to run
        public override bool FinishedLaunching(UIApplication app, NSDictionary options)
        {
            _window = new UIWindow(UIScreen.MainScreen.Bounds);

            // initialize app
            // example: MXTouchContainer.Initialize(new HelloWorld.App(), this, _window);

            // initialize views
            MXTouchContainer.AddView<string>(new Views.MessageView(), ViewPerspective.Default);

            MXTouchContainer.Navigate(null, MXContainer.Instance.App.NavigateOnLoad);

            return true;
        }

        // This method is required in iPhoneOS 3.0
        public override void OnActivated(UIApplication application)
        {
        }
    }
}

