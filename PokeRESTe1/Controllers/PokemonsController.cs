using Microsoft.AspNetCore.Mvc;
using PokemonAPI.Models;
using PokemonAPI.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PokemonAPI.Controllers
{
    [Route("api/[controller]")]
    //URI: api/pokemons
    [ApiController]
    public class PokemonsController : ControllerBase
    {
        private PokemonsRepository _repository;

        public PokemonsController(PokemonsRepository repository)
        {
            _repository = repository;
        }

        // GET: api/<PokemonsController>
        [HttpGet]
        public IEnumerable<Pokemon> Get()
        {
            List<Pokemon> result = _repository.GetAll();
            return result;
        }

        // GET api/<PokemonsController>/5
        [HttpGet("{id}")]
        public Pokemon Get(int id)
        {
            Pokemon? foundPokemon = _repository.GetByID(id);
            return foundPokemon;
        }

        // POST api/<PokemonsController>
        [HttpPost]
        public Pokemon Post([FromBody] Pokemon newPokemon)
        {
            Pokemon createdPokemon = _repository.Add(newPokemon);
            return createdPokemon;
        }

        // PUT api/<PokemonsController>/5
        [HttpPut("{id}")]
        public ActionResult<Pokemon> Put(int id, [FromBody] Pokemon updates)
        {

            Pokemon? updatedPokemon = _repository.Update(id, updates);
            return updatedPokemon;
        }

        // DELETE api/<PokemonsController>/5
        [HttpDelete("{id}")]
        public Pokemon Delete(int id)
        {
            Pokemon? deletedPokemon = _repository.Delete(id);
            return deletedPokemon;
        }
    }
}
