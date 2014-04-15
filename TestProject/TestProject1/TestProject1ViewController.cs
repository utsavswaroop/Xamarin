using System;
using System.Drawing;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace TestProject1
{
	public partial class TestProject1ViewController : UIViewController
	{
		public TestProject1ViewController () : base ("TestProject1ViewController", null)
		{
		}

		public override void DidReceiveMemoryWarning ()
		{
			// Releases the view if it doesn't have a superview.
			base.DidReceiveMemoryWarning ();
			
			// Release any cached data, images, etc that aren't in use.
		}

		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();
			
			// Perform any additional setup after loading the view, typically from a nib.
			System.Console.WriteLine ("View did load");
		}

		partial void DisplayButtonPress (NSObject sender)
		{
			DisplayLabel.Text = "Hello World";
//			UIAlertView alert = new UIAlertView ("Title", "Display AlertView", null , "OK", "Cancel");
//			alert.Show();

//			UIAlertView alert = new UIAlertView ("Alert Title", "Choose from two buttons", null, "OK", new string[] {"Cancel"});
//			alert.Clicked += (s, b) => {
//				DisplayLabel.Text = "Button " + b.ButtonIndex.ToString () + " clicked";
//				Console.WriteLine ("Button " + b.ButtonIndex.ToString () + " clicked");
//			};
//			alert.Show();

			UIAlertView alert = new UIAlertView () {
				Title = "custom buttons alert", 
				Message = "this alert has custom buttons"
			};
			alert.AddButton("OK");
			alert.AddButton("custom button 1");
			alert.AddButton("Cancel");

			alert.Clicked += delegate(object a, UIButtonEventArgs b) {
				DisplayLabel.Text = "Button " + b.ButtonIndex.ToString () + " clicked";
				Console.WriteLine ("Button " + b.ButtonIndex.ToString () + " clicked"); };
			alert.Show ();
		}
	}
}

