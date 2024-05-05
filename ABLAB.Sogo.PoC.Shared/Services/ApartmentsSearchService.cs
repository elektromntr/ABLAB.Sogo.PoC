using ABLAB.Sogo.PoC.Shared.Dtos;
using System.Net.Http.Json;
using Flurl;

namespace ABLAB.Sogo.PoC.Shared.Services;

public class ApartmentsSearchService
{
    private readonly HttpClient _client = new();

    public SearchParameters Parameters { get; set; } = default!;
    public IList<ApartmentDto>? Apartments { get; set; } = default!;

    public ApartmentsSearchService()
    {
        _client.BaseAddress = new Uri("http://localhost:56861/api/2/");
    }

    public async Task SearchApartments(SearchParameters searchParameters)
    {
        var queryUrl = "search".SetQueryParams(searchParameters);
        var apartmentsRequest = await _client.GetAsync(queryUrl);
        Apartments = await apartmentsRequest.Content.ReadFromJsonAsync<List<ApartmentDto>>();
    }

    public async Task GetSearchParams()
    {
        var parameters = await _client.GetFromJsonAsync<SearchParameters>("search-params");
        Parameters = parameters!;
    }
}