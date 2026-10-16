using CincyGuard.Server.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace CincyGuard.Server.Services;

public class CrimeApiService
{
    private readonly HttpClient _client;

    public CrimeApiService(HttpClient client)
    {
        _client = client;
        _client.BaseAddress = new Uri("https://data.cincinnati-oh.gov/resource/");
    }

    public async Task<List<CrimeIncident>> GetCrimeDataAsync()
    {
        var options = new JsonSerializerOptions
        {
            NumberHandling = JsonNumberHandling.AllowReadingFromString
        };

        return await _client.GetFromJsonAsync<List<CrimeIncident>>("t9kw-3jfx.json?$limit=1000", options);
    }
}