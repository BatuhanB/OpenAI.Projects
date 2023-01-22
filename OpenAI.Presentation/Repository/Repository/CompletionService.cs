using OpenAI.Presentation.Repository.Interfaces;
using OpenAI.Service.Dtos;
using OpenAI.Service.Models;
using System.Text.Json;

namespace OpenAI.Presentation.Repository.Repository
{
	public class CompletionService : IHttpClientRepository
	{
		private readonly HttpClient _httpClient;

		public CompletionService(HttpClient httpClient)
		{
			_httpClient = httpClient;
		}

		private T Deserialize<T>(string json) => JsonSerializer.Deserialize<T>(json);

		public async Task<ICollection<Completion>> GetAsync(string prompt)
		{
			var result = await _httpClient.GetFromJsonAsync<ICollection<Completion>>($"Completion/GetCompletion/{prompt}");
			return result;
		}
	}
}
