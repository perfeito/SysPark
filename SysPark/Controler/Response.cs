using System;
using System.Text.RegularExpressions;

namespace SysPark.Controler
{
    class Response
    {
        /// <summary>
        /// Texto de resposta recebido do servidor.
        /// </summary>
        public String Text { get; set; }

        /// <summary>
        ///  Construtor
        /// </summary>
        /// <param name="responseText">
        /// HTML retornado pelo servidor que
        /// será usado para construir o endereço
        /// </param>
        public Response(string responseText)
        {
            this.Text = responseText;
        }

        /// <summary>
        /// Método responsável por capturar um componente do endereço
        /// na responsta do servidor. Por Macelo de Souza.
        /// </summary>
        /// 
        /// <param name="tag"></param>
        /// <returns></returns>
        private string GetValueByTag(string tag)
        {
            try
            {
                string value = this.Text;

                value = value.Replace("\r", "").Replace("\n", "");
                value = value.Substring(value.IndexOf("<span class=\"resposta\">" + tag));
                value = value.Substring(value.IndexOf("<span class=\"respostadestaque\">") + 31);

                string result = value.Substring(0, value.IndexOf("</span>"));
                return result.Trim();
            }
            catch (ArgumentOutOfRangeException)
            {
                return String.Empty;
            }
        }

        /// <summary>
        /// Método responsável por realizar a conversão
        /// da resposta recebida do servidor para um objeto
        /// do tipo Address.
        /// </summary>
        /// <returns></returns>
        public Address ToAddress()
        {
            Address address = new Address();

            address.Street = this.GetValueByTag("Logradouro");
            address.District = this.GetValueByTag("Bairro");
            address.City = Regex.Match(this.GetValueByTag("Localidade"), "^(.*?)   ").Groups[1].Value;
            address.State = Regex.Match(this.GetValueByTag("Localidade"), "([A-Z]{2})$").Groups[1].Value;
            address.Cep = this.GetValueByTag("CEP");

            if (address.Street == String.Empty)
                address.CepUnico = true;

            return address;
        }
    }
}
