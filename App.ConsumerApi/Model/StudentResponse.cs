using Newtonsoft.Json;
using System;

namespace App.RefitConsumer.Model
{
    public class StudentResponse
    {
        [JsonProperty("nome")]
        public string Nome { get; set; }

        [JsonProperty("aniversario")]
        public DateTime Aniversario { get; set; }

        [JsonProperty("cpf")]
        public string Cpf { get; set; }

        [JsonProperty("ativo")]
        public bool Ativo { get; set; }

        [JsonProperty("endereco")]
        public string Endereco { get; set; }

        [JsonProperty("id")]
        public Guid Id { get; set; }

    }
}
