using System.Collections.Generic;
using System.Threading.Tasks;
using PokeApiNet;
using PokePrism.Services.Interfaces;

namespace PokePrism.Services {
    public class PokemonService : IPokemonService {
        private readonly PokeApiClient _pokeApiClient = new();
        private const int TotalNumberOfPokemon = 10;

        public async Task<IEnumerable<Pokemon>> GetAllPokemon() {
            var pokeHandler = await _pokeApiClient.GetNamedResourcePageAsync<Pokemon>(TotalNumberOfPokemon, 0);
            var allPokemonList = await _pokeApiClient.GetResourceAsync<Pokemon>(pokeHandler.Results);
            return allPokemonList;
        }
    }
}
