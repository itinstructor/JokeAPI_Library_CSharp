using Newtonsoft.Json;
using System;
using System.Net;


namespace JokeAPIV2
{
    class Program
    {
        // JokeAPI URL for Any joke in safe-mode
        // dark, explicit jokes are not retrieved
        private const string API = "https://v2.jokeapi.dev/joke/Any?&safe-mode";
        static void Main(string[] args)
        {
            // Create the http WebClient to GET API call
            WebClient client = new WebClient();

            // Create string to store Json data
            string jsonString;
            
            // GET the json data, store in jsonString
            jsonString = client.DownloadString(API);
            
            // Convert Json into C# Class
            JokeAPIV2.Joke joke = JsonConvert.DeserializeObject<JokeAPIV2.Joke>(jsonString);

            // For debugging, display raw Json data
            // Console.WriteLine(jsonString);

            Console.WriteLine("GET a joke");

            // Jok is displayed as properties of joke object
            Console.WriteLine($"\n{joke.setup}");
            Console.WriteLine($"\n{joke.delivery}");

            // Pause the program
            Console.ReadLine();
        }
    }
}

