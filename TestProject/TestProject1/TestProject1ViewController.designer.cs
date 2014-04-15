// WARNING
//
// This file has been generated automatically by Xamarin Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;
using System.CodeDom.Compiler;

namespace TestProject1
{
	[Register ("TestProject1ViewController")]
	partial class TestProject1ViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIButton DisplayButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel DisplayLabel { get; set; }

		[Action ("DisplayButtonPress:")]
		partial void DisplayButtonPress (MonoTouch.Foundation.NSObject sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (DisplayLabel != null) {
				DisplayLabel.Dispose ();
				DisplayLabel = null;
			}

			if (DisplayButton != null) {
				DisplayButton.Dispose ();
				DisplayButton = null;
			}
		}
	}
}
