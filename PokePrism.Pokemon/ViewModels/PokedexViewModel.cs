using System.Collections.ObjectModel;
using System.Windows;
using PokePrism.Services.Interfaces;
using Prism.Commands;
using Prism.Mvvm;

namespace PokePrism.Pokemon.ViewModels {
    public class PokedexViewModel : BindableBase {
        private readonly IPokemonService _service;
        private ObservableCollection<PokeApiNet.Pokemon> _pokemonList;

        // TODO: can't use "using PokeApiNet"
        public ObservableCollection<PokeApiNet.Pokemon> PokemonList {
            get => _pokemonList;
            set => SetProperty(ref _pokemonList, value);
        }
        
        public PokedexViewModel(IPokemonService service) {
            _service = service;
            LoadData();
        }
        
        private void LoadData() {
            _service.GetAllPokemon()
                    .ContinueWith(task => PokemonList = new ObservableCollection<PokeApiNet.Pokemon>(task.Result));
        }
    }
}
