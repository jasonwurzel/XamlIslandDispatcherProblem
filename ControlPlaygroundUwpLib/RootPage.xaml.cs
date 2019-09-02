using System;
using System.Diagnostics;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Xaml;

namespace ControlPlaygroundUwpLib
{
    public sealed partial class RootPage
    {
        public RootPage()
        {
            InitializeComponent();

            Loaded += OnLoaded;
        }

        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            try
            {
                // This works
                var currentDispatcher = Window.Current.Dispatcher;
                // This throws
                CoreDispatcher coreDispatcher = CoreApplication.Views[0].Dispatcher;
            }
            catch
            {
                Debugger.Break();
            }
        }
    }
}
