using System;
class Program{
    public static void Main(string[] args){
 
        string nome;
        double salario, anos;
        
        Console.WriteLine("Digite seu nome: ");
        nome = (Console.ReadLine());
        Console.WriteLine("Qual é o seu salário?: ");
        salario = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Há quantos anos você é funcionário desta empresa?: ");
        anos = Convert.ToInt32(Console.ReadLine());

        if(anos >= 10){
            salario = salario * 1.20;
            Console.WriteLine("Seu salário atual, com aumento, é " + salario);
        }
        else if(anos < 10 && anos > 3){
            salario = salario * 1.125;
            Console.WriteLine("Seu salário atual, com aumento, é " + salario);
        }
        else if(anos < 3){
            salario = salario * 1.03;
            Console.WriteLine("Seu salário atual, com aumento, é " + salario);
        }
        else{
            Console.WriteLine("Hm... Tem algo de errado aí! :/");
    }   
}
}
