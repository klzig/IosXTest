using MvvmCross.Binding.BindingContext;
using MvvmCross.iOS.Views;
using IosXTest.Core.ViewModels;
using System;

using UIKit;
using MvvmCross.iOS.Views.Presenters.Attributes;

namespace IosXTest.iOS.Views
{
    public partial class FirstView : MvxViewController<FirstViewModel>
    {
        public FirstView() : base("FirstView", null)
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
            var set = this.CreateBindingSet<FirstView, FirstViewModel>();
            set.Bind(Label).To(vm => vm.Hello);
            set.Bind(TextField).To(vm => vm.Hello);
            set.Bind(Nav1Button).To(vm => vm.ButtonCommand);
            set.Apply();
        }

        partial void Nav2Button_TouchUpInside(UIButton sender)
        {
            ViewModel.NavigateTo();
        }
    }
}