using System;

class challenger{
    static void Main(string[] arg){
        Console.ForegroundColor = ConsoleColor.Green;

        Console.Write("insert a number to pyramid:");
        int number = Convert.ToInt32(Console.ReadLine());

        for(int i = 1; i < number; i++){
            Console.WriteLine(" ");

            for(int j = i; j < (i * 2); j++){
                Console.Write("*");
            }
        }


        Console.ReadKey();
    }
}
