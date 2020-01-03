using Prism.Ioc;
using LoaBarracks.Views;
using System.Windows;
using Prism.Modularity;
using LoaBarracks.Modules.Menu;

namespace LoaBarracks
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App
    {
        protected override Window CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {

        }

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return base.CreateModuleCatalog();
        }

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog)
        {
            moduleCatalog.AddModule<MenuModule>();
            base.ConfigureModuleCatalog(moduleCatalog);
        }

        protected override void ConfigureServiceLocator()
        {
            base.ConfigureServiceLocator();
        }

        protected override void RegisterRequiredTypes(IContainerRegistry containerRegistry)
        {
            base.RegisterRequiredTypes(containerRegistry);
        }

    }
}
