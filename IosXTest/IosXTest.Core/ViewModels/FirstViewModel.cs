using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System.Windows.Input;


namespace IosXTest.Core.ViewModels
{
    public class FirstViewModel : MvxViewModel
    {
        private readonly IMvxNavigationService _navigationService;

        public FirstViewModel(IMvxNavigationService navigationService)
        {
            _navigationService = navigationService;
        }

        string hello = "Hello MvvmCross";
        public string Hello
        {
            get { return hello; }
            set { SetProperty(ref hello, value); }
        }

        public IMvxAsyncCommand ButtonCommand
        {
            // Makes it here...
            get => new MvxAsyncCommand(() => _navigationService.Navigate<SecondViewModel>());
        }
    }
}
