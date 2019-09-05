using System;
using System.Diagnostics;
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
                try
                {
                    // this throws
                    var mainThreadScheduler = RxApp.MainThreadScheduler;
                }
                catch (Exception)
                {
                    Debugger.Break();
                    throw;
                }
            };
        }
    }
}
