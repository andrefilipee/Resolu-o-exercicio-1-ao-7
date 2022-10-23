using System;
    
    public class areaQuadrado{
    public static void Main(string[] args){


          double comprimento, altura, area;
         Console.Write("Comprimento: ");

         comprimento = Convert.ToDouble(Console.ReadLine());



          Console.Write("Altura: ");
          altura = Convert.ToDouble(Console.ReadLine());

        area = comprimento * altura;
         Console.WriteLine("Área: " + area);





    }   

}