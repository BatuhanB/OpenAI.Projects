using Microsoft.AspNetCore.Mvc;
using OpenAI.Service.Services;

namespace OpenAI.API.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class CompletionController : ControllerBase
	{
		private readonly TextCompletions _service;


		public CompletionController(TextCompletions service)
		{
			_service = service;

		}

		[HttpGet("GetCompletion")]
		public async Task<IActionResult> GetCompletion(string prompt)
		{
			var result = await _service.Get(prompt);
			return Ok(result);
		}

	}
}
