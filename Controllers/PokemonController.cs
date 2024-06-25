using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PokemonMvc.Models;
using System.Net;
using System.Net.Http.Headers;

namespace PokemonMvc.Controllers
{
    public class PokemonController : Controller
    {
        public string uriBase = "http://mukabertoni.somee.com/Api/Pokemon/";

        [HttpGet]
        public async Task<ActionResult> IndexAsync()
        {
            try
            {
                HttpClient httpClient = new HttpClient();
                HttpResponseMessage response = await httpClient.GetAsync(uriBase);
                string serialized = await response.Content.ReadAsStringAsync();

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    List<PokemonViewModel> listaPokemon = await Task.Run(() =>
                        JsonConvert.DeserializeObject<List<PokemonViewModel>>(serialized)!);

                    return View(listaPokemon);
                }
                else
                    throw new Exception(serialized);
            }
            catch (Exception ex)
            {
                TempData["MensagemErro"] = ex.Message;
                return RedirectToAction("Index", "Home");
            }
        }
    }

}