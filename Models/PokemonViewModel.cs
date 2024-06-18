using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using PokemonMvc.Models.Enuns;

namespace PokemonMvc.Models
{
    public class PokemonViewModel
    {
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public double Altura { get; set; }
        public double Peso { get; set; }
        public string Genero { get; set; } = "";
        public List<TipoEnum> Tipo { get; set; }
    }
}