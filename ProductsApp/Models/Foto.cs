using System;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace ProductsApp.Models
{

    public class Foto
    {
		[JsonProperty("_id")]
		public int Id { get; set; }
		[Required]
		[JsonProperty("titulo")]
		public string Titulo { get; set; }
		[JsonProperty("url")]
		public string Url { get; set; }
		[JsonProperty("descricao")]
		public decimal Descricao { get; set; }
    }
}
