namespace _05_Exercicio.Classes
{
    public class Pizzaria
    {
        private Pizza pizza;
        public void CriarPizza(string tipo)
        {
            if (tipo.Equals("mussarela"))
            {
                pizza = new PizzaMussarela();
            }
            else if (tipo.Equals("calabresa"))
            {
                pizza = new PizzaCalabresa();
            }
        }
    }
}
