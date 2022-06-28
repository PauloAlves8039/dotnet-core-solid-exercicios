using System.Collections.Generic;

namespace _01_Exercicio.Classes
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Pais { get; set; }
        public string Email { get; set; }

        public static List<Cliente> ObterListaDeClientes() 
        {
            var listaDeClientes = new List<Cliente>() 
            {
                new Cliente{ Nome="Pedro", Pais="Brasil", Email="pedro@email.com" },
                new Cliente{ Nome="Florencia", Pais="Chile", Email="maria@email.com" },
                new Cliente{ Nome="Florencia", Pais="Chile", Email="maria@email.com" },
                new Cliente{ Nome="Sofia", Pais="Paraguai", Email="sofia@email.com" }
            };

            return listaDeClientes;
        }
    }
}
