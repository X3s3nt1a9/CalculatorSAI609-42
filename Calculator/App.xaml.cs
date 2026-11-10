using Microsoft.Extensions.DependencyInjection;

namespace Calculator
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }


        protected override Window CreateWindow(IActivationState? activationState)
        {
            var window =  new Window(new AppShell());

            window.Width = 750;
            window.Height = 650;

            window.MinimumWidth = 700;
            window.MinimumHeight = 600;

            return window;
        }
    }
}