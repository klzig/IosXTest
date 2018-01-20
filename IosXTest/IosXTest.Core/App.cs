using MvvmCross.Platform.IoC;

namespace IosXTest.Core
{
    public class App : MvvmCross.Core.ViewModels.MvxApplication
    {
        public override void Initialize()
        {
            base.Initialize();
            RegisterNavigationServiceAppStart<ViewModels.FirstViewModel>();
        }
    }
}
