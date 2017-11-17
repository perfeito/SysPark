using System;

namespace SysPark.Controler
{
    /// <summary>
    /// Modelo de endereço, todos os dados setados nessa classe
    /// serão submetido as validações como pode ver.
    /// </summary>
    /// 
    /// <see cref="http://volkoinen.github.com/Correios.Net"/>
    /// <see cref="https://github.com/volkoinen/Correios.Net"/>
    public class Address
    {
        private string _Cep;
        private string _Street;
        private string _District;
        private string _City;
        private string _State;

        /// <summary>
        /// A validação para o CEP permite apenas strings de
        /// oito nove digitos com ou sem máscara, apenas seguindo
        /// os seguintes padroes: 99999999 ou 99999-999.
        /// </summary>
        /// 
        /// <see cref="http://volkoinen.github.com/Correios.Net"/>
        /// <see cref="https://github.com/volkoinen/Correios.Net"/>
        public String Cep
        {
            get
            {
                return this._Cep;
            }
            set
            {
                int count = 0;

                if (value.Length != 8 && value.Length != 9)
                    throw new InvalidArgumentException("O CEP informado é inválido.");

                foreach (char c in value)
                    if (Char.IsDigit(c))
                        count++;

                if (count != 8)
                    throw new InvalidArgumentException("O CEP informado é inválido.");

                this._Cep = value;
            }
        }

        /// <summary>
        /// A validação do endereço verifica apenas se o mesmo
        /// tem um número de caracteres maior do que 500.
        /// </summary>
        /// 
        /// <see cref="http://volkoinen.github.com/Correios.Net"/>
        /// <see cref="https://github.com/volkoinen/Correios.Net"/>
        public String Street
        {
            get
            {
                return this._Street;
            }
            set
            {
                if (value.Length > 500)
                    throw new InvalidArgumentException("O tamanho da rua não pode exceder 500 caracteres.");

                this._Street = value;
            }
        }

        /// <summary>
        /// A validação do distrito verifica apenas se o valor informado
        /// tem um tamanho de no máximo 500 caracteres.
        /// </summary>
        /// 
        /// <see cref="http://volkoinen.github.com/Correios.Net"/>
        /// <see cref="https://github.com/volkoinen/Correios.Net"/>
        public String District
        {
            get
            {
                return this._District;
            }
            set
            {
                if (value.Length > 500)
                    throw new InvalidArgumentException("O tamanho do bairro não pode exceder 500 caracteres.");

                this._District = value;
            }
        }

        /// <summary>
        /// A validação da ciade verifica apenas se o valor informado
        /// tem um tamanho de no máximo 500 caracteres.
        /// </summary>
        /// 
        /// <see cref="http://volkoinen.github.com/Correios.Net"/>
        /// <see cref="https://github.com/volkoinen/Correios.Net"/>
        public String City
        {
            get
            {
                return this._City;
            }
            set
            {
                if (value.Length > 500)
                    throw new InvalidArgumentException("O tamanho da cidade não pode exceder 500 caracteres.");

                this._City = value;
            }
        }

        /// <summary>
        /// Verifica se o UF informado é
        /// </summary>
        ///
        /// <see cref="http://volkoinen.github.com/Correios.Net"/>
        /// <see cref="https://github.com/volkoinen/Correios.Net"/>
        public String State
        {
            get
            {
                return this._State;
            }
            set
            {
                bool validState = false;

                string[] states =
                {
                    "AC", 
                    "AL", 
                    "AM", 
                    "AP", 
                    "BA", 
                    "CE", 
                    "DF", 
                    "ES", 
                    "GO",
                    "MA",
                    "MG",
                    "MS",
                    "MT",
                    "PA",
                    "PB",
                    "PE",
                    "PI",
                    "PR",
                    "RJ",
                    "RN",
                    "RO",
                    "RR",
                    "RS",
                    "SC",
                    "SE",
                    "SP",
                    "TO"

                    //"Acre - AC", 
                    //"Alagoas - AL", 
                    //"Amapá - AP", 
                    //"Amazonas - AM", 
                    //"Bahia - BA", 
                    //"Ceará - CE", 
                    //"Distrito Federal - DF", 
                    //"Espírito Santo - ES", 
                    //"Goiás - GO",
                    //"Maranhão - MA",
                    //"Mato Grosso - MT",
                    //"Mato Grosso do Sul - MS",
                    //"Minas Gerais - MG",
                    //"Pará - PA",
                    //"Paraíba - PB",
                    //"Paraná - PR",
                    //"Pernambuco - PE",
                    //"Piauí - PI",
                    //"Rio de Janeiro - RJ",
                    //"Rio Grande do Norte - RN",
                    //"Rio Grande do Sul - RS",
                    //"Rondônia - RO",
                    //"Roraima - RR",
                    //"Santa Catarina - SC",
                    //"São Paulo - SP",
                    //"Sergipe - SE",
                    //"Tocantins - TO"
                };

                foreach (string state in states)
                    if (value.ToUpper() == state)
                    {
                        validState = true;
                        this._State = value.ToUpper();
                    }

                if (!validState && !string.IsNullOrEmpty(value))
                    throw new InvalidArgumentException("A sigla da unidade federativa informada é inválida.");
            }
        }

        /// <summary>
        /// True quando for um cep único para toda a cidade.
        /// </summary>
        public Boolean CepUnico { get; set; }
    }
}
