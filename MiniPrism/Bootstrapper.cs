using Microsoft.Practices.Unity;
using MiniPrism.Views;
using Prism.Unity;
using System.Windows;

namespace MiniPrism
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
