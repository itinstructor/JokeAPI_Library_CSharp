/**
* Project:       JokeAPIV2
* Programmer:    William Loring
* Date:          03/12/2021
* Description:   Base class for JokeAPI library wrapper
 */
namespace JokeAPIV2
{
    public class Joke
    {
        public bool error { get; set; }

        public string category { get; set; }

        public string type { get; set; }

        // Retrieve the joke setup
        public string setup { get; set; }

        // Retrieve the joke delivery
        public string delivery { get; set; }

        public bool flag { get; set; }

        public bool safe { get; set; }

        public long id { get; set; }

        public string lang { get; set; }
    }
}
