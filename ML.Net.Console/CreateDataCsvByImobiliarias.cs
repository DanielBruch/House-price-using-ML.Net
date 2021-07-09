using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace ia_toniazo
{
    public class CreateDataBySantaMaria
    {
        public string CreateData()
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                       | SecurityProtocolType.Tls11
                                       | SecurityProtocolType.Tls12;

            var client = new RestClient("https://santamaria.com.br/reload-vendas");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            var running = true;
            var page = 1;
            var responseCSV = "";
            while (page <= 11)
            {
                var body = new
                {
                    mobiliado = 3,
                    valorMin = 0,
                    valorMax = 9900000,
                    page = page
                };
                request.AddBody(JsonConvert.SerializeObject(body));
                IRestResponse response = client.Execute(request);
                if (response.IsSuccessful)
                {
                    var content = JsonConvert.DeserializeObject<List<ListResponse>>(response.Content);
                    content.ForEach(q =>
                    {
                        var p = LoadSingleData(q.Codigo);
                        var responseitem = $"{p.Categoria};{p.Bairro };{p.Cidade };{p.ValorVenda };{p.Dormitorios };{p.Suites };{p.Vagas };{p.AreaPrivativa };{p.AreaTotal}\r\n";
                        responseCSV += responseitem;
                    });
                }
                page++;
            }
            return responseCSV;
        }
        private SingleResponse LoadSingleData(string Cod)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls
                                   | SecurityProtocolType.Tls11
                                   | SecurityProtocolType.Tls12;

            var client = new RestClient("https://santamaria.com.br/load-detalhes-vendas");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.RequestFormat = RestSharp.DataFormat.Json;
            var body = new
            {
                codigo = Cod,
            };
            request.AddHeader("content-type", "application/x-www-form-urlencoded");
            request.AddObject(body);
            IRestResponse response = client.Execute(request);
            var teste = JObject.Parse(response.Content)[Cod];
            return teste.ToObject<SingleResponse>();

        }
    }
    public class ListResponse
    {
        public string Codigo { get; set; }
    }
    public class SingleResponse
    {
        public string Categoria { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string ValorVenda { get; set; }
        public string Dormitorios { get; set; }
        public string Suites { get; set; }
        public string Vagas { get; set; }
        public string AreaPrivativa { get; set; }
        public string AreaTotal { get; set; }

    }
}
