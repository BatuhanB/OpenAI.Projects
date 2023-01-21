# E-CommerceAPI

<div align="center">
<img alt="BatuhanB" width="200" height="200" src="https://user-images.githubusercontent.com/56514839/200259435-347a3bdd-e062-4338-b2e3-21f86c547106.png"/>

<h3>What have been used in this project ?</h3>
 <img src="https://img.shields.io/badge/C%23-239120?style=for-the-badge&logo=c-sharp&logoColor=white"/>
 <!--<img src="https://img.shields.io/badge/PostgreSQL-316192?style=for-the-badge&logo=postgresql&logoColor=white"/>-->
</div>

## Project Description
This project have been made for use OpenAI Text Completion by TextDavinciV3 and Image Generation using OpenAI API's. 
# Little information!
 - The project requires a pricing plan to use Open API's API.
 - It is a small amount of money. For example 1k tokens cost $0.0020.
 - For more information u can visit https://openai.com/api/pricing/ adress.

## Project Description 

First of all you need a api key to use openai services. And inject this key to your json file or directly in your program.cs file. But even in openapi documentation they recommend, do not use apikey on your json file. It is not the safest way to keep your key. Insted you should use secret.json of visual studio. Well you can ask me that 'How can i implement my apiKey to secret json file ?' here is how.
 1. First step you should add path file 
 ```csharp
 %APPDATA%\Microsoft\UserSecrets\<user_secrets_id>\secrets.json 
 ```
 3. In the preceding file paths, replace ``` <user_secrets_id> ``` with the UserSecretsId value specified in the project file.
 4. For Enable secret storage ``` dotnet user-secrets init  ``` run the following command in the project directory.
 5. And you should able to see ypur secretUserId in the following code block
 ```csharp
  <PropertyGroup>
  <TargetFramework>netcoreapp3.1</TargetFramework>
  <UserSecretsId>79a3edd0-2092-40a2-a04d-dcb46d5ca9ed</UserSecretsId>
  </PropertyGroup>
  ```
 6. After adding the usersecret *in the solution files click right click on **Web API project folder** and click **Manage Users Secret*** 
 7. And you should able to see the secret.json file only need to do is defining your api key like the following 
 ```csharp 
 {
  "OpenAIServiceOptions": {
    "ApiKey": "____"
  }
}
 
 ```
 8. Once you have done that you are ready to write methods to use services.
