using System;
using System.Net;
using System.Runtime.Intrinsics.X86;

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


        //---------------------------Clico IF para controlar a seleção dos exercicios-------------------------------------------------------------------------------**
        //if (int.tryparse(numexercicio, out int numero))
        //{ }
        //else
        //{
        //    console.writeline("opção incorreta!tente novamente");
        //}
        //console.read();
        //---------------------------------------------------------------------------------------------------------------------------------------------------------**

        //---------Exercicio 1------------------------------------------------------------------------------------------------------------------------------------------------**

        //decimal comprimento, altura, area;
        //Console.Write("comprimento:");

        //comprimento = decimal.Parse(Console.ReadLine());
        //Console.Write("altura: ");
        //altura = decimal.Parse(Console.ReadLine());
        //area = comprimento * altura;
        //Console.WriteLine("área: " + area);
        //---------------------------------------------------------------------------------------------------------------------------------------------------------**

        //----Exercicio 2-----------------------------------------------------------------------------------------------------------------------------------------------------**

        //2 – Uma empresa pretende criar um pequeno programa que deve receber do teclado os valores
        //correspondentes aos salários brutos dos seus funcionários e apresentar o respetivos recibos de pagamento (discriminação apenas do salário líquido).

        //Tenha em atenção a informação seguinte(valores fictícios):
        //• Desconto para a Segurança Social(20 % do vencimento bruto);
        //• Desconto para o IRS, aplicando as diferentes taxas:

        //        -Se o vencimento bruto for inferior a 500€, há isenção;
        //        -Se o vencimento bruto for superior ou igual a 500€ e inferior a 1000€, a dedução será de 12 %;
        //        -Se o vencimento bruto for superior ou igual a 1000€ e inferior a 1500€, a dedução será 15 %;      200  
        //        -Se o vencimento bruto for superior a 1500€, a dedução será 18 %.


        double salBruto, salLiquido, segSocial, irs;

        Console.WriteLine(" Exercicio 2 ");
        Console.Write("");
        Console.WriteLine(" Introduza o Salário Bruto: ");

        salBruto = double.Parse(Console.ReadLine());
        segSocial = salBruto * 0.20;

        if (salBruto < 500)
        {
            irs = 500;
        }
        else if (salBruto >= 500 && salBruto < 1000)
        {
            irs = 0.12;
        }
        else if (salBruto >= 1000 && salBruto < 1500)
        {
            irs = 0.15;
        }
        else
        {
            irs = 0.18;
        }

        salLiquido = (salBruto - segSocial) - (salBruto * irs);

      Console.WriteLine("O Salário Líquido é de:" + salLiquido );



        




    }

}