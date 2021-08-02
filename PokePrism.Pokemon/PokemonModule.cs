using PokePrism.Core;
using PokePrism.Pokemon.Views;
using Prism.Ioc;
using Prism.Modularity;
using Prism.Regions;

namespace PokePrism.Pokemon {
    public class PokemonModule : IModule {
        private readonly IRegionManager _regionManager;

        public PokemonModule(IRegionManager regionManager) {
            _regionManager = regionManager;
        }
        
        public void RegisterTypes(IContainerRegistry containerRegistry) {
            containerRegistry.Register<PokedexView>();
        }

        public void OnInitialized(IContainerProvider containerProvider) {
            _regionManager.RegisterViewWithRegion<PokedexView>(RegionNames.PokedexRegion);
        }
    }
}
