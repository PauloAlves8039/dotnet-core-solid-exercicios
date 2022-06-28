namespace _01_Exercicio.Classes
{
    public class LocalizarCliente
    {
        public static Cliente PesquisarPorPais(string pais) 
        {
            var resultado = Cliente.ObterListaDeClientes().Find(c => c.Pais == pais);
            return resultado;
        }

        public static Cliente PesquisarPorNome(string nome) 
        {
            var resultado = Cliente.ObterListaDeClientes().Find(c => c.Nome == nome);
            return resultado;
        }
    }
}
