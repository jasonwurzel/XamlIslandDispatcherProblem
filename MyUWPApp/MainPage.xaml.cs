using Windows.UI.Xaml.Controls;
using ReactiveUI;

namespace MyUWPApp
{
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            Loaded += (_, __) =>
            {
                var mainThreadScheduler = RxApp.MainThreadScheduler;
            };
        }
    }
}
