using _02_Exercicio.Interfaces;
using System;

namespace _02_Exercicio.Classes
{
    public class Pedido
    {
        private ILogger _log;

        public Pedido(ILogger log)
        {
            _log = log;
        }

        public virtual void AdicionarPedido() 
        {
            try
            {
                _log.Registrar($"Pedido Incluindo em : {DateTime.Now}");
            }
            catch (Exception ex) 
            {
                _log.Registrar($"{ex} - {DateTime.Now}");
            }
        }

    }
}
