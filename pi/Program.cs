using System;

class Program
{
    static void Main()
    {
        //Вимір кола
        long circumference = 245850922;
        long diameter = 78256779;

        //Обчислення 
        string piContinuedFraction = GetPiContinuedFraction(circumference, diameter);


        Console.WriteLine(piContinuedFraction); //результат
    }

    static string GetPiContinuedFraction(long circumference, long diameter)
    {
        // пошук цілої част і залишку
        long integerPart = circumference / diameter;
        long remainder = circumference % diameter;

        string continuedFraction = $"{integerPart}\n3+-----------------------------";

        while (remainder != 0)
        {
            // Знаходимо новий діаметр
            long newDiameter = diameter - remainder;

            //нова ціла частина і залишок
            long newIntegerPart = newDiameter / remainder;
            remainder = newDiameter % remainder;

            // нова ціла частина
            continuedFraction += $"\n{newIntegerPart}\n{(newIntegerPart * 2 + 1)}+-----------------------------";

            //додаєм "+" для початку наст кроку
            if (remainder != 0)
                continuedFraction += $"\n                1";
        }

        return continuedFraction;
    }
}
