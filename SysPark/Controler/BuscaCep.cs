namespace SysPark.Controler
{
    /// <summary>
    /// Classe responsável por permitir a busca de um endereço
    /// através de um número CEP utilizando os serviços disponibilizados
    /// no site dos correios para consulta.
    /// </summary>
    /// 
    /// <see cref="http://volkoinen.github.com/Correios.Net"/>
    /// <see cref="https://github.com/volkoinen/Correios.Net"/>
    public class BuscaCep
    {

        /// <summary>
        /// Realiza a busca do endereço a partir do cep no site dos correios
        /// </summary>
        /// <param name="cep">Cep utilizado para busca</param>
        /// <returns>Address</returns>
        public static Address GetAddress(string cep)
        {
            var address = new Address();
            address.Cep = cep;

            string url = "http://m.correios.com.br/movel/buscaCepConfirma.do";
            string dataToPost = "cepEntrada=" + cep + "&tipoCep=&cepTemp=&metodo=buscarCep";
            string method = "POST";
            string contentType = "application/x-www-form-urlencoded";

            Request request =
                new Request(url, dataToPost, method, contentType);

            Response response = request.Send();
            return response.ToAddress();
        }

    }
}
