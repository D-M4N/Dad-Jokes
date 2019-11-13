using System;
using System.Threading.Tasks;
using DadJokesLibrary;

namespace DadJokesLibrary
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string jokeString = await JokeGenerator.GetRandomJokeAsync();
            
            Console.WriteLine(jokeString);

            /*Console.WriteLine("Hello World!");*/
        }
    }
}
