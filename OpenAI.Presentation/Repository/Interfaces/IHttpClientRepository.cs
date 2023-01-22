using OpenAI.Service.Dtos;
using OpenAI.Service.Models;

namespace OpenAI.Presentation.Repository.Interfaces
{
	public interface IHttpClientRepository
	{
		Task<ICollection<Completion>> GetAsync(string prompt);
		//Task PostAsync(PostCompletionDto completion);
		//Task PutAync(Completion completion);
	}
}
