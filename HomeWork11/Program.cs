
using System;

class Program
{
    static void Main()
    {
        System.Console.OutputEncoding = System.Text.Encoding.UTF8;

        string corectWord = "програмування";
        
        char[] stepWord = new string('_', corectWord.Length).ToCharArray();
       
        int attempts = corectWord.Length;
        
        string incorrectGuesses = "";

        Console.WriteLine("Вітаємо! Спробуйте вгадати зашифроване слово!");
        Console.WriteLine($"Кількість літер у слові: {corectWord.Length}");
        Console.WriteLine($"Кількість можливих невірних спроб: {corectWord.Length}");

        while (attempts > 0 && new string(stepWord) != corectWord)
        {
            Console.WriteLine($"\nНевірні спроби: {incorrectGuesses}");
            Console.WriteLine($"Залишилося спроб: {attempts}");
            Console.Write("Введіть букву: ");
            char guess = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (incorrectGuesses.Contains(guess) || Array.Exists(stepWord, c => c == guess))
            {
                Console.WriteLine("Ви вже вводили цю букву. Спробуйте іншу.");
                continue;
            }

            if (corectWord.Contains(guess))
            {
                for (int i = 0; i < corectWord.Length; i++)
                {
                    if (corectWord[i] == guess)
                    {
                        stepWord[i] = guess;
                    }
                }
                Console.WriteLine($"Така літера є у слові! {new string(stepWord)}");
            }
            else
            {
                
                incorrectGuesses += guess;
                attempts--;
                Console.WriteLine($"Такої літери немає! {new string(stepWord)}");
            }
        }

        if (new string(stepWord) == corectWord)
        {
            Console.WriteLine($"Вітаємо, ви вгадали слово! Загадане слово було: {corectWord}");
        }
        else
        {
            Console.WriteLine($"Ви програли! Загадане слово було: {corectWord}");
        }
    }
}
