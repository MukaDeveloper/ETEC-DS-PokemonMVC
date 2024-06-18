using System.Text.Json.Serialization;
using PokemonMvc.Models.Enuns;

namespace PokemonMvc.Models
{
    public class PokemonViewModel
    {
        //Atalho: PROP + TAB
        public int Id { get; set; }
        public string Nome { get; set; } = "";
        public double Altura { get; set; }
        public double Peso { get; set; }
        public List<TipoEnum> Tipo { get; set; }
    }
}