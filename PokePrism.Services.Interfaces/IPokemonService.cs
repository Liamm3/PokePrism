using System.Collections.Generic;
using System.Threading.Tasks;
using PokeApiNet;

namespace PokePrism.Services.Interfaces {
    public interface IPokemonService {
        public Task<IEnumerable<Pokemon>> GetAllPokemon();
    }
}
