using System;
using System.Collections.Generic;
using System.Net.Http;
using Lab5PokeAPITesting;
using Newtonsoft.Json;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the name of a Pokemon or Pokedex entry of a Pokemon for Pokemon Type information: ");
        string pokemonIdentifier = Console.ReadLine();

        try
        {
            PokemonData pokemonData = GetPokemonData(pokemonIdentifier);
            Console.WriteLine($"Name: {pokemonData.Name}");
            Console.WriteLine($"PokeDex Entry: {pokemonData.Id}");
            Console.WriteLine("Types:");
            foreach (var type in pokemonData.Types)
            {
                Console.WriteLine($"- {type.Type}");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Entered Pokémon ID/Name does not exist or is spelled wrong (use lowercase): {ex.Message}");
        }
    }

    static PokemonData GetPokemonData(string identifier)
    {
        using (HttpClient client = new HttpClient())
        {
            HttpResponseMessage response = client.GetAsync($"https://pokeapi.co/api/v2/pokemon/{identifier}/").Result;

            if (response.IsSuccessStatusCode)
            {
                string jsonResponse = response.Content.ReadAsStringAsync().Result;
                dynamic pokemonJson = JsonConvert.DeserializeObject(jsonResponse);

                PokemonData pokemon = new PokemonData
                {
                    Name = pokemonJson.name,
                    Id = pokemonJson.id,
                    Types = new List<PokemonType>()
                };

                foreach (var typeEntry in pokemonJson.types)
                {
                    pokemon.Types.Add(new PokemonType { Type = typeEntry.type.name });
                }

                return pokemon;
            }
            else
            {
                throw new Exception($"Did not work, response code: {response.StatusCode}");
            }
        }
    }
}
