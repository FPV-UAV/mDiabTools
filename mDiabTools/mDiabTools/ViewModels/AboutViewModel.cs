using System;
using System.Windows.Input;

using Xamarin.Forms;

namespace mDiabTools.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public AboutViewModel()
        {
            Title = "About";

//            OpenWebCommand = new Command(() => Device.OpenUri(new Uri("https://xamarin.com/platform")));
            OpenWebCommand = new Command(() => App.bleInit());
        }

        public ICommand OpenWebCommand { get; }
    }
}