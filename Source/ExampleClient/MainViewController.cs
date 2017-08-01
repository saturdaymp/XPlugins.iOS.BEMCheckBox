using SaturdayMP.XPlugins.iOS;
using UIKit;

namespace BindingExample
{
    public partial class MainViewController : UIViewController
    {
        public MainViewController() : base("MainViewController", null)
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();

            Title = "Binding Example";

            var bemCheckBoxLabel = new UILabel()
            {
                Text = "BEMCheckBox:",
                Frame = new CoreGraphics.CGRect(10, 40, 125, 25)
            };

            var checkbox = new BEMCheckBox(new CoreGraphics.CGRect(140, 40, 25, 25));


            View.AddSubview(bemCheckBoxLabel);
            View.AddSubview(checkbox);
        }
    }
}