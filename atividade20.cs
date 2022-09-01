using System;
class Program{
    public static void Main(string[] args){

        double altura, peso, imc;

        Console.WriteLine("Digite seu peso ");
        peso = double.Parse(Console.ReadLine());
        Console.WriteLine("Digite sua altura ");
        altura = double.Parse(Console.ReadLine());

        imc = (altura * altura) / peso;
        //altura²/peso

        if(imc > 30){
            Console.WriteLine("Obesidade");
        }
        else if(imc > 25 ){
            Console.WriteLine("Sobrepeso");
        }
        else if(imc > 18.5){
            Console.WriteLine("Peso ideal");
        }
        else if(imc < 18.5){
            Console.WriteLine("Abaixo do peso");
        }
       

}
}   
 
