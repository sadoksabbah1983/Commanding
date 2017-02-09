using Commanding.Modules.Oder.Desktop.Services;
using Microsoft.Practices.Prism.Modularity;
using Microsoft.Practices.Prism.Regions;
using Microsoft.Practices.Unity;
using Commanding.Modules.Oder.Desktop.Views;

namespace Commanding.Modules.Oder.Desktop
{
    public class OrderModule :IModule
    {
        private readonly IRegionManager regionManager;
        private readonly IUnityContainer container;

        public OrderModule(IUnityContainer container,IRegionManager regionManager)
        {
            this.container = container;
            this.regionManager = regionManager;
        }

        public void Initialize()
        {
            this.container.RegisterType<IOrdersReposity, OrdersReposity>(new ContainerControlledLifetimeManager());

            this.regionManager.RegisterViewWithRegion("MainRegion", 
                                                                () => this.container.Resolve<OrdersEditorView>());

            //this.regionManager.RegisterViewWithRegion("GlobalCommandRegion",
            //    () => this.container.Resolve<OrdersToolBar>());
        }
    }
}
