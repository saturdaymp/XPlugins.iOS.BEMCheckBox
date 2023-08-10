using System;
using UIKit;
using SaturdayMP.XPlugins.iOS;

namespace ExampleClient
{
    public partial class ViewController : UIViewController
    {
        public ViewController (IntPtr handle) : base (handle)
        {
        }

        public override void ViewDidLoad ()
        {
            base.ViewDidLoad ();
            // Perform any additional setup after loading the view, typically from a nib.

            // Create the actual checkbox.  Remember to pass in the size you want as a CoreGraphics.
            var checkbox = new BEMCheckBox(new CoreGraphics.CGRect(140, 40, 25, 25));

            // Add the controls to the view.
            View.AddSubview(checkbox);
        }

        public override void DidReceiveMemoryWarning ()
        {
            base.DidReceiveMemoryWarning ();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}