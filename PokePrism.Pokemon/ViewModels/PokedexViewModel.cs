using System.Collections.ObjectModel;
using PokePrism.Services.Interfaces;
using Prism.Mvvm;

namespace PokePrism.Pokemon.ViewModels {
    public class PokedexViewModel : BindableBase {
        private readonly IPokemonService _service;
        private ObservableCollection<PokeApiNet.Pokemon> _pokemonList;
        private PokeApiNet.Pokemon _selectedPokemon;

        public PokedexViewModel(IPokemonService service) {
            _service = service;
            LoadData();
        }

        // TODO: can't use "using PokeApiNet"
        public ObservableCollection<PokeApiNet.Pokemon> PokemonList {
            get => _pokemonList;
            set => SetProperty(ref _pokemonList, value);
        }

        public PokeApiNet.Pokemon SelectedPokemon {
            get => _selectedPokemon;
            set => SetProperty(ref _selectedPokemon, value);
        }

        private void LoadData() {
            _service.GetAllPokemon()
                    .ContinueWith(task => PokemonList = new ObservableCollection<PokeApiNet.Pokemon>(task.Result));
        }
    }
}
