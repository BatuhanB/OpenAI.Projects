using Microsoft.AspNetCore.Mvc;
using OpenAI.Presentation.Repository.Repository;

namespace OpenAI.Presentation.Controllers
{
	public class CompletionController : Controller
	{
		private readonly CompletionService _completionService;

		public CompletionController(CompletionService completionService)
		{
			_completionService = completionService;
		}

		public IActionResult Index()
		{
			return View();
		}

		public async Task<IActionResult> GetAsync(string prompt)
		{
			var response = await _completionService.GetAsync(prompt);
			var result = response.ToList();
			return View(result);
		}
	}
}
