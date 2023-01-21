using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using OpenAI.GPT3.Extensions;
using OpenAI.Service.Services;

namespace OpenAI.Service.Configurations.Extensions
{
	public static class DependencyResolver
	{
		public static IServiceCollection AddServices(this IServiceCollection services, IConfiguration configuration)
		{
			var apiKey = configuration["OpenAIServiceOptions:ApiKey"];
			services.AddSingleton<TextCompletions>();
			services.AddOpenAIService(settings => { settings.ApiKey = apiKey; });
			return services;
		}

	}
}
