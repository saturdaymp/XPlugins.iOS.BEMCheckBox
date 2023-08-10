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

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "Binding Example";


            // Create a label for the CheckBox.
            var bemCheckBoxLabel = new UILabel()
            {
                Text = "BEMCheckBox:",
                Frame = new CoreGraphics.CGRect(10, 40, 125, 25)
            };


            // Create the actual checkbox.  Remember to pass in the size you want as a CoreGraphics.
            var checkbox = new BEMCheckBox(new CoreGraphics.CGRect(140, 40, 25, 25));

            // Wire up the events.  You don't have to do this if you don't care
            // about the events.  An easy way to think of the events is:
            //
            // DidTapCheckBox: Before checkbox checked.
            // AnimationDidStopForCheckBox: After checkbox checked.
            //
            // See BEMCheckBox for more details:
            //
            // https://github.com/Boris-Em/BEMCheckBox
            checkbox.DidTap += DidTapEvent;
            checkbox.AnimationDidStop += AnimationDidStopEvent;


            // Add the controls to the view.
            View.AddSubview(bemCheckBoxLabel);
            View.AddSubview(checkbox);
        }

        // Fired before the checkbox animation completes but after the internal
        // checkbox settings are updated with the new check/unchecked status (i.e.
        // On property is updated).
        private void DidTapEvent(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("In BeforeCheckBoxClickedEvent which is DidTapCheckBox in BEMCheckBox.");
        }

        // Fired after the checkbox animation completes.  If there are no animations then
        // it won't be triggered.
        private void AnimationDidStopEvent(object sender, EventArgs eventArgs)
        {
            Console.WriteLine("In AfterCheckBoxClickedEvent which is AnimationDidStopForCheckBox in BEMCheckBox.");
        }
    }
}