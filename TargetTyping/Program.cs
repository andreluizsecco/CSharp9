using System;
using System.Drawing;

namespace TargetTyping
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Target Typed - New Expressions
            Point point = new(3, 5);

            Console.WriteLine($"New Expressions: X => {point.X} | Y => {point.Y}");

            // Target Typing Conditional Operators

            // Nullable Value Types
            var resultado = 99;
            int? contador = resultado == 1 ? 0 : null;

            Console.WriteLine($"Nullable Value Types: {contador}");

            
            //Shared Base Types
            Gato gato = null;
            Cachorro cachorro = new();

            // OBS: Nesse preview (preview 8) ainda está acusando erro de compilação
            Animal animal = gato ?? cachorro;
        }
    }

    public class Animal { }

    public class Gato : Animal { }

    public class Cachorro : Animal { }
}
