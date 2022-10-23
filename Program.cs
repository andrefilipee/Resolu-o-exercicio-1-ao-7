using System;

public class areaQuadrado {
    public static void Main()

    { 
        Console.WriteLine("Digite uma opção para exibir o resultado do exercício");
        Console.WriteLine(" ");
        Console.WriteLine("Para o Exercício 01 digite: 1");
        Console.WriteLine("Para o Exercício 02 digite: 2");
        Console.WriteLine("Para o Exercício 03 digite: 3");
        Console.WriteLine("Para o Exercício 04 digite: 4");
        Console.WriteLine("Para o Exercício 05 digite: 5");
        Console.WriteLine("Para o Exercício 06 digite: 6");
        Console.WriteLine("Para o Exercício 07 digite: 7");

        Console.Write("Opção");
        string numExercicio = Console.ReadLine();
        Console.WriteLine("");
        if(int.TryParse(numExercicio, out int numero))
            { }
        else
        {
            Console.WriteLine("Opção incorreta!Tente novamente");
        }
        Console.Read();



        decimal comprimento, altura, area;
         Console.Write("Comprimento: ");

         comprimento = decimal.Parse(Console.ReadLine());
          Console.Write("Altura: ");
         altura = decimal.Parse(Console.ReadLine());
         area = comprimento * altura;
         Console.WriteLine("Área: " + area);





    }   

}