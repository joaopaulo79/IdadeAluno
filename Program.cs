using System;

namespace IdadeAluno
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime data1 = new DateTime(2003, 10, 29), data2 = new DateTime(2021, 10, 29);
            string nascimento = data1.ToLongDateString(), aniversario = data2.ToLongDateString();
            DateTime semana1 = Convert.ToDateTime(nascimento), semana2 = Convert.ToDateTime(aniversario);
            
            
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            
            Console.WriteLine(                
            $"\nEu nasci em {nascimento}\nFaço 18 anos em {aniversario}.\n");

            Console.ResetColor();
        }
    }
}
