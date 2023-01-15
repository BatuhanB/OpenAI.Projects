namespace OpenAI.Service.Models
{
	public class Completion
	{
		public string Prompt { get; set; }
		public string Response { get; set; }
		public int Token { get; set; }
		public List<string> Error { get; set; }

	}
}
