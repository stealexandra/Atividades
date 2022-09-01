using System;
 
class Programa{
 	public static void Main(string[] args){
        int um, dois, tres;

        Console.WriteLine("Digite o valor do primeiro lado: ");
        um = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor do segundo lado: ");
        dois = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Digite o valor do terceiro lado: ");
        tres = Convert.ToInt32(Console.ReadLine());
        
        if((um < (dois + tres)) && (dois < (um + tres)) && (tres < (um + dois))){
            Console.WriteLine("Você pode criar um triângulo com essas retas");
        } else {
            Console.WriteLine("Você não pode criar um triângulo com essas retas");
        }
        if((um == dois && um == tres)){
            Console.WriteLine("Isso torna um triângulo equilátero");
        }
        else if((um == dois && um != tres) || (um==tres && um != tres) || (dois==tres && tres != um)){
            Console.WriteLine("Isso torna um triângulo isósceles");
        }
        else if((um != dois && um != dois)){
            Console.WriteLine("Isso torna um triângulo escaleno");
        }
    }
}
