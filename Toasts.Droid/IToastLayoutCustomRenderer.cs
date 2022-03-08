using Android.App;
using Android.Views;

namespace Toasts.Droid
{
    public interface IToastLayoutCustomRenderer
    {
        View Render(Activity activity, ToastNotificationType type, string title, string description, object context);
    }
}
