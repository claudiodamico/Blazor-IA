using OpenAI_API;
using OpenAI_API.Completions;

namespace sofIA.Services
{
    public class AnswerGeneratorServices : IAnswerGeneratorServices
    {
        public async Task<string> GenerateAnswer(string prompt)
        {
            string apikey = "My_GPT_Api_Key";
            string answer = string.Empty;

            var openai = new OpenAIAPI(apikey);
            CompletionRequest completion = new CompletionRequest();
            completion.Prompt = prompt;
            completion.MaxTokens = 400;
            completion.Temperature = 1;
            var result = await openai.Completions.CreateCompletionAsync(completion);

            if (result != null)
            {
                foreach (var item in result.Completions)
                {
                    answer = item.Text;
                }
            }

            return answer;
        }
    }
}
