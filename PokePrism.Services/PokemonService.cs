using System.Collections.Generic;
using System.Threading.Tasks;
using PokeApiNet;
using PokePrism.Services.Interfaces;

namespace PokePrism.Services {
    public class PokemonService : IPokemonService {
        private const int TotalNumberOfPokemon = 5;
        private readonly PokeApiClient _pokeApiClient = new();

        public async Task<IEnumerable<Pokemon>> GetAllPokemon() {
            var pokeHandler = await _pokeApiClient.GetNamedResourcePageAsync<Pokemon>(TotalNumberOfPokemon, 0);
            var allPokemonList = await _pokeApiClient.GetResourceAsync(pokeHandler.Results);
            return allPokemonList;
        }
    }
}
