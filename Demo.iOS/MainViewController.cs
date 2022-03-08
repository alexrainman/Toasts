using System;
using MvvmCross.Platforms.Ios.Views;
using Toasts;
using Toasts.iOS;
using UIKit;

namespace Demo.iOS
{
    public partial class MainViewController : MvxViewController<MainViewModel>
    {
        public MainViewController() : base("MainViewController", null)
        {
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.

            NavigationController.NavigationBar.Translucent = false;
            View.BackgroundColor = UIColor.SystemBackgroundColor;

            Title = "Toasts";

            showInfo.TouchUpInside += (s, e) => ShowToast(ToastNotificationType.Info);

            showSuccess.TouchUpInside += (s, e) => ShowToast(ToastNotificationType.Success);

            showWarning.TouchUpInside += (s, e) => ShowToast(ToastNotificationType.Warning);

            showError.TouchUpInside += (s, e) => ShowToast(ToastNotificationType.Error);

            showCustom.TouchUpInside += (s, e) => ShowToast(ToastNotificationType.Custom);
        }

        private async void ShowToast(ToastNotificationType type)
        {
            var notificator = new ToastNotificatorImplementation() as IToastNotificator;
            bool tapped = await notificator.Notify(type, "Mixed martial arts sometimes referred to as cage fighting, is a full-contact combat sport based on striking, grappling and ground fighting, incorporating techniques from various combat sports and martial.", "Sorry about that.", TimeSpan.FromSeconds(3));
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}

