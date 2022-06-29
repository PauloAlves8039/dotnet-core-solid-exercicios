using _02_Exercicio.Interfaces;
using System.IO;

namespace _02_Exercicio.Classes
{
    public class FileLogger : ILogger
    {
        public void Registrar(string mensagem)
        {
            File.WriteAllText(@"C:\dados\LogOcorrencias.txt", mensagem);
        }
    }
}
