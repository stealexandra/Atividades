using System;
 
class Programa{
 	public static void Main(string[] args){
        string car;
        int km, dia;
        Console.WriteLine("Qual carro você pegou emprestado? (P) - popular e (L) - luxo)")
        car = Console.ReadLine()
        Console.WriteLine("Quantos foram os km percorridos?")
        km = Convert.ToInt32(Console.ReadLine())
        Console.WriteLine("Qual foi o tempo do empréstimo em dias?")
        dia = Convert.ToInt32(Console.ReadLine())

        if(car == "P" && km <= 100){
            dia = dia * 90
            km = km * 0.20
            Console.WriteLine("Você deve pagar R$" + dia + " pelo tempo usado e R$" + km + "pelos quilômetros rodados")
        }
        if(car == "P" && km > 100){
            dia = dia * 90
            km = km * 0.10
            Console.WriteLine("Você deve pagar R$" + dia + " pelo tempo usado e R$" + km + "pelos quilômetros rodados")
        }
        if(car == "L" && km <= 200){
            dia = dia * 150
            km = km * 0.30
            Console.WriteLine("Você deve pagar R$" + dia + " pelo tempo usado e R$" + km + "pelos quilômetros rodados")
        }
        if(car == "L" && km > 200){
            dia = dia * 150
            km = km * 0.25
            Console.WriteLine("Você deve pagar R$" + dia + " pelo tempo usado e R$" + km + "pelos quilômetros rodados")
    }
}
