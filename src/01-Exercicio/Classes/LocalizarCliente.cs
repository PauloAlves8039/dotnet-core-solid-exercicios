namespace _01_Exercicio.Classes
{
    public class LocalizarCliente
    {
        public static Cliente PesquisarPorPais(string pais) 
        {
            var resultado = Cliente.ObtendoListaDeClientes().Find(c => c.Pais == pais);
            return resultado;
        }

        public static Cliente PesquisarPorNome(string nome) 
        {
            var resultado = Cliente.ObtendoListaDeClientes().Find(c => c.Nome == nome);
            return resultado;
        }
    }
}
