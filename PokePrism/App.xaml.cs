using System.Windows;
using PokePrism.Pokemon;
using PokePrism.Views;
using Prism.Ioc;
using Prism.Modularity;

namespace PokePrism {
    public partial class App {
        protected override void RegisterTypes(IContainerRegistry containerRegistry) {
        }

        protected override Window CreateShell() => Container.Resolve<ShellWindow>();

        protected override void ConfigureModuleCatalog(IModuleCatalog moduleCatalog) {
            base.ConfigureModuleCatalog(moduleCatalog);
            moduleCatalog.AddModule<PokemonModule>();
        }
    }
}
