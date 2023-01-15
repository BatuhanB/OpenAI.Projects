using OpenAI.GPT3.Extensions;
using OpenAI.Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


//IConfiguration configuration = new ConfigurationBuilder()
//	.SetBasePath(builder.Environment.ContentRootPath)
//	.AddJsonFile("ApiSettings.json")
//	.AddUserSecrets<Program>().Build();


builder.Services.AddSingleton<TextCompletions>();
builder.Services.AddOpenAIService(x => { x.ApiKey = "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"; });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
	app.UseSwagger();
	app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
