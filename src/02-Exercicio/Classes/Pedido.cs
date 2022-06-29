using System;

namespace _02_Exercicio.Classes
{
    public class Pedido
    {
        private ConsoleLogger log = new ConsoleLogger();

        public virtual void AdicionarPedido() 
        {
            try
            {
                log.Registrar($"Pedido Incluindo em : {DateTime.Now}");
            }
            catch (Exception ex) 
            {
                log.Registrar($"{ex} - {DateTime.Now}");
            }
        }

    }
}
