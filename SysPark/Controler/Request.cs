﻿using System.Text;
using System.Net;
using System.IO;

namespace SysPark.Controler
{
    class Request
    {
        public string Url { get; set; }
        public string DataToSend { get; set; }
        public string Method { get; set; }
        public string ContentType { get; set; }

        /// <summary>
        /// Construtor, responsável por construir a requisição
        /// que será enviada para o site dos correios.
        /// </summary>
        /// 
        /// <param name="url">Url que será acessada</param>
        /// <param name="dataToSend">Dados que serão enviados</param>
        /// <param name="method">Método da requisição</param>
        /// <param name="contentType">Tipo do dado enviado para o servidor</param>
        public Request(string url, string dataToSend, string method, string contentType)
        {
            this.Url = url;
            this.DataToSend = dataToSend;
            this.Method = method;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Envia a requisição construida através dos parâmetros
        /// passados para o construtor para o servidor e retorna
        /// a resposta recebida.
        /// </summary>
        /// 
        /// <returns>Response</returns>
        public Response Send()
        {
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(this.Url);
            request.Method = this.Method;
            request.ContentType = this.ContentType;
            byte[] postBytes = Encoding.ASCII.GetBytes(this.DataToSend);

            request.GetRequestStream()
                .Write(postBytes, 0, postBytes.Length);

            string responseText = new StreamReader(request.GetResponse().GetResponseStream(), Encoding.GetEncoding("ISO-8859-1")).ReadToEnd();

            return new Response(responseText);
        }
    }
}
