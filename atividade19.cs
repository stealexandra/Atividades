using System;
 
class Programa{
 	public static void Main(string[] args){
    int val, sal, ano, x, y;

    Console.WriteLine("Digite o valor do imóvel: ");
    val = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Digite o valor do seu salário ");
    sal = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Parcelar o pagamento em quantos anos? ");
    ano = Convert.ToInt32(Console.ReadLine());

	x = val/ano;
	y = x/12;
	if(x <= sal/0.30){
		Console.WriteLine("Empréstimo aprovado. O pagamento por ano será de " + x + " E o mensal será de " + y);
	} else {
		Console.WriteLine("Empréstimo negado. O valor mensal será maior que 30% de seu salário");
	}

    }
}
