using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BankSampleMary.Model
{
    public class Cliente
    {
        [JsonProperty(PropertyName = "id")]
        public Guid Id { get; set; }
        [JsonProperty(PropertyName = "nome")]
        public string Nome { get; set; }
        [JsonProperty(PropertyName = "dataNascimento")]
        public DateTime DataNascimento { get; set; }

        [JsonProperty(PropertyName = "sexo")]
        public string Sexo { get; set; }
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
        [JsonProperty(PropertyName = "telefones")]
        public List<Telefone> Telefones { get; set; }
        [JsonProperty(PropertyName = "enderecos")]
        public List<Endereco> Enderecos { get; set; }
    }
    public class Telefone
    {
        [JsonProperty(PropertyName = "DDD")]
        public string DDD { get; set; }
        [JsonProperty(PropertyName = "numero")]
        public string Numero { get; set; }
    }
    public class Endereco
    {
        [JsonProperty(PropertyName = "logradouro")]
        public string Logradouro { get; set; }
        [JsonProperty(PropertyName = "complemento")]
        public string Complemento { get; set; }
        [JsonProperty(PropertyName = "bairro")]
        public string Bairro { get; set; }
        [JsonProperty(PropertyName = "cidade")]
        public string Cidade { get; set; }
        [JsonProperty(PropertyName = "estado")]
        public string Estado { get; set; }
    }
}
