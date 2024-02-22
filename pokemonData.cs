using Lab5PokeAPITesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
public class PokemonData
{
    public string Name { get; set; }
    public int Id { get; set; }
    public List<PokemonType> Types { get; set; }
}
