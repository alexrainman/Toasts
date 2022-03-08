// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Demo.iOS
{
	[Register ("MainViewController")]
	partial class MainViewController
	{
		[Outlet]
		UIKit.UIButton showCustom { get; set; }

		[Outlet]
		UIKit.UIButton showError { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton showInfo { get; set; }

		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UIKit.UIButton showSuccess { get; set; }

		[Outlet]
		UIKit.UIButton showWarning { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (showError != null) {
				showError.Dispose ();
				showError = null;
			}

			if (showWarning != null) {
				showWarning.Dispose ();
				showWarning = null;
			}

			if (showInfo != null) {
				showInfo.Dispose ();
				showInfo = null;
			}

			if (showSuccess != null) {
				showSuccess.Dispose ();
				showSuccess = null;
			}

			if (showCustom != null) {
				showCustom.Dispose ();
				showCustom = null;
			}
		}
	}
}
