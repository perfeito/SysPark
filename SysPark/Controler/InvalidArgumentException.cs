using System;

namespace SysPark.Controler
{
    /// <summary>
    /// Exception Personalizada utilizada na validação dos dados
    /// de entrada(parâmetros) utilizados na Correios.Net.
    /// </summary>
    [Serializable]
    class InvalidArgumentException : Exception
    {
        public InvalidArgumentException(string message)
            : base(message)
        {
        }
    }
}
