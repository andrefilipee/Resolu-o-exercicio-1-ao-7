using System;
    
    public class areaQuadrado{
    public static void Main(){


          decimal comprimento, altura, area;
         Console.Write("Comprimento: ");

         comprimento = decimal.Parse(Console.ReadLine());



          Console.Write("Altura: ");
          altura = decimal.Parse(Console.ReadLine());

        area = comprimento * altura;
         Console.WriteLine("Área: " + area);





    }   

}