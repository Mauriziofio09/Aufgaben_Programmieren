using System;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

public class Program
{
    public static async Task Main(string[] args)
    {
        using (var client = new HttpClient())
        {
            while (true)
            {
                await GetAndPrintJoke(client);

                Console.Write("\nNächsten Witz holen? (j/n): ");
                string? userInput = Console.ReadLine()?.ToLower();

                if (userInput != "j")
                {
                    break;
                }
                Console.WriteLine();
            }
        }
    }

    public static async Task GetAndPrintJoke(HttpClient client)
    {
        try
        {
            string apiUrl = "https://v2.jokeapi.dev/joke/Any?lang=de";

            HttpResponseMessage response = await client.GetAsync(apiUrl);
            
            response.EnsureSuccessStatusCode();

            string jsonResponse = await response.Content.ReadAsStringAsync();

            Joke? joke = JsonSerializer.Deserialize<Joke>(jsonResponse);

            if (joke != null)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                if (joke.Type == "single")
                {
                    Console.WriteLine(joke.SingleJoke);
                }
                else // Der Typ ist "twopart"
                {
                    Console.WriteLine($"{joke.Setup} - {joke.Delivery}");
                }

                Console.ResetColor();
            }
        }
        catch (HttpRequestException e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Fehler bei der API-Anfrage: {e.Message}");
            Console.ResetColor();
        }
    }
}

public class Joke
{
   
    [JsonPropertyName("type")]
    public string? Type { get; set; }

    [JsonPropertyName("joke")]
    public string? SingleJoke { get; set; }

    [JsonPropertyName("setup")]
    public string? Setup { get; set; }

    [JsonPropertyName("delivery")]
    public string? Delivery { get; set; }
}