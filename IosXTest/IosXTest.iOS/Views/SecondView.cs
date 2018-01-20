using System;
using MvvmCross.iOS.Views;
using MvvmCross.iOS.Views.Presenters.Attributes;
using IosXTest.Core.ViewModels;

using UIKit;

namespace IosXTest.iOS.Views
{
    [MvxRootPresentation (WrapInNavigationController = false)]
    public partial class SecondView : MvxViewController<SecondViewModel>
    {
        public SecondView() : base("SecondView", null)
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

            // Perform any additional setup after loading the view, typically from a nib.
        }
    }
}