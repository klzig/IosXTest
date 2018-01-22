using MvvmCross.Core.Navigation;
using MvvmCross.Core.ViewModels;
using System.Threading.Tasks;
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
            // Makes it here then crashes:
            //Unhandled Exception:
            //MvvmCross.Platform.Exceptions.MvxException: Failed to construct and initialize ViewModel for type IosXTest.Core.ViewModels.SecondViewModel from locator MvxDefaultViewModelLocator - check InnerException for more information occurred
            //--- inner exception ---
            //Failed to find constructor for type IosXTest.Core.ViewModels.SecondViewModel (MvvmCross.Platform.Exceptions.MvxIoCResolveException)
            //  at MvvmCross.Platform.IoC.MvxSimpleIoCContainer.IoCConstruct(System.Type type)[0x00012] in C:\projects\mvvmcross\MvvmCross\Platform\Platform\IoC\MvxSimpleIoCContainer.cs:367 
            //  at MvvmCross.Platform.Mvx.IocConstruct(System.Type t) [0x00006] in C:\projects\mvvmcross\MvvmCross\Platform\Platform\Mvx.cs:169 
            //  at MvvmCross.Core.ViewModels.MvxDefaultViewModelLocator.Load(System.Type viewModelType, MvvmCross.Core.ViewModels.IMvxBundle parameterValues, MvvmCross.Core.ViewModels.IMvxBundle savedState) [0x00000] in C:\projects\mvvmcross\MvvmCross\Core\Core\ViewModels\MvxDefaultViewModelLocator.cs:43 

            get => new MvxAsyncCommand(() => _navigationService.Navigate<SecondViewModel>());
        }

        public async Task NavigateTo()
        {
            // Makes it here and does nothing (app doesn't crash but view isn't shown)
            await _navigationService.Navigate<SecondViewModel>();
        //    await _navigationService.Navigate(typeof(SecondViewModel), null);     // Same result with this form
        }
    }
}
