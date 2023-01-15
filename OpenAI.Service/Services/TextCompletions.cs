using OpenAI.GPT3.Interfaces;
using OpenAI.GPT3.ObjectModels.RequestModels;
using OpenAI.Service.Models;
using static OpenAI.GPT3.ObjectModels.Models;

namespace OpenAI.Service.Services
{
	public class TextCompletions
	{
		private readonly IOpenAIService _service;

		public TextCompletions(IOpenAIService service)
		{
			_service = service;
		}

		public async Task<string> Get(string prompt)
		{
			var model = new Completion();
			model.Prompt = prompt;
			model.Token = 500;
			try
			{
				var result = await _service.Completions.CreateCompletion(new CompletionCreateRequest()
				{
					Prompt = model.Prompt,
					MaxTokens = model.Token
				}, TextDavinciV3);

				if (result.Successful)
				{
					//Console.WriteLine(result.Choices.FirstOrDefault());
					return model.Response = result.Choices[0].Text;
				}
				else
				{
					if (result.Error is null)
					{
						//throw new Exception("Unkown Error!");
						model.Error.Add("Unkown Error!");
						throw new Exception(model.Error.ToString());
					}
					else
					{
						//Console.WriteLine($"{result.Error.Code}: {result.Error.Message}");
						model.Error.Add($"{result.Error.Code}: {result.Error.Message}");
						throw new Exception(model.Error.ToString());
					}
				}
				//Console.WriteLine(result.Choices.FirstOrDefault());
				return model.Response = result.Choices[0].Text;
			}
			catch (Exception e)
			{
				throw e;
			}
		}
	}
}
