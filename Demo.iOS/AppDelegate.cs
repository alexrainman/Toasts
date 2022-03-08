using Foundation;
using MvvmCross;
using MvvmCross.Platforms.Ios.Core;
using Toasts;
using Toasts.iOS;
using UIKit;

namespace Demo.iOS
{
    // The UIApplicationDelegate for the application. This class is responsible for launching the
    // User Interface of the application, as well as listening (and optionally responding) to application events from iOS.
    [Register("AppDelegate")]
    public class AppDelegate : MvxApplicationDelegate<MvxIosSetup<App>, App>
    {
        public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
        {
            var result = base.FinishedLaunching(application, launchOptions);

            Mvx.IoCProvider.RegisterSingleton<IToastNotificator>(new ToastNotificatorImplementation());
            var customStyleSheet = new CustomStyleSheet();
            ToastNotificatorImplementation.Init(customStyleSheet);

            return result;
        }

        class CustomStyleSheet : MessageBarStyleSheet
        {
            public override UIColor BackgroundColorForMessageType(ToastNotificationType type)
            {
                if (type == ToastNotificationType.Custom)
                {
                    return UIColor.FromRGB(22, 22, 22); //#161616
                }

                return base.BackgroundColorForMessageType(type);
            }

            public override UIImage IconImageForMessageType(ToastNotificationType type)
            {
                if (type == ToastNotificationType.Custom)
                {
                    return UIImage.FromBundle("video_not_available");
                }

                return base.IconImageForMessageType(type);
            }

            public override UIColor StrokeColorForMessageType(ToastNotificationType type)
            {
                if (type == ToastNotificationType.Custom)
                {
                    return UIColor.FromRGB(22, 22, 22); //#161616
                }

                return base.StrokeColorForMessageType(type);
            }
        }
    }
}

