using static System.Console;
namespace Teste_4
{
  class program
  {
    
    public static void Main(string []args)
    {
      int ValorDesconto,ValorTotal;

      ValorDesconto = 0;
    WriteLine("Digite o valor da compra: ");
    var Valor = int.Parse(ReadLine());
    
        if (Valor >=300 && Valor <=2200)
        {
        ValorDesconto = Valor -200;
        ValorDesconto = ValorDesconto/100;
        ValorTotal = Valor - ValorDesconto;
        WriteLine($"O valor da compra foi de R${Valor}; A porcentagem de descondo adquirida foi de {ValorDesconto}%; O total da sua compra já com desconto é R${ValorTotal}.");
        }
        if (Valor >2200)
        {
        ValorDesconto = (Valor/100)*20;
        ValorTotal = Valor - ValorDesconto;
        WriteLine($"O valor da compra foi de R${Valor}; A porcentagem de descondo adquirida foi de 20%; O total da sua compra já com desconto é R${ValorTotal}.");
        }
        else if (Valor <300)
        {
          WriteLine ("Infelizmente você não adquiriu descontos :( ");
        }
    }
  }
}