using System.Windows;
using Microsoft.Practices.Prism.UnityExtensions;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Unity;

using Commanding.Modules.Oder.Desktop;

namespace CommandPrism
{
    class Bootstrapper :UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<Shell>();
        }

        protected override void InitializeShell()
        {
            base.InitializeShell();
            App.Current.MainWindow = (Window) this.Shell;
            App.Current.MainWindow.Show();
        }

        protected override void ConfigureModuleCatalog()
        {


            base.ConfigureModuleCatalog();
            ModuleCatalog moduleCatalog = (ModuleCatalog) this.ModuleCatalog;
            moduleCatalog.AddModule(typeof(OrderModule));
        }
    }
}
