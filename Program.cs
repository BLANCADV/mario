using System;

namespace mario
{
    class Program
    {
        static void Main(string[] args)
        {
            int Altura,Esp,Hash,Actual;
            System.Console.WriteLine("programadores:MENDOZA MERCADO CRISTINA CECILIA y BLANCA GUADALUPE DELGADO VALENCIA");
          Console.WriteLine("dibujar piramide");
          Console.WriteLine("Ingresa la altura de la piramide no mayor a 23 ni menor a 1");
          Altura = Convert.ToInt32(Console.ReadLine());
             while(Altura > 23 || Altura < 1)
             {
                 Console.Write("Altura: ");
                 int.TryParse(Console.ReadLine(),out Altura);
             }
             for(Actual =1; Actual < Altura - Actual; Actual++)
             {
                 for(Esp =0; Esp < Altura-Actual; Esp++)
                 {
                     Console.Write(" ");
                 }
                 for(Hash =0; Hash < (Actual*2)-1; Hash++)
                 {
                     Console.Write("#",1);
                 }
                 Console.WriteLine();
             }




          Console.ReadKey();
        }
    }
}