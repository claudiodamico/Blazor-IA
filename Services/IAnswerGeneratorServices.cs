namespace sofIA.Services
{
    public interface IAnswerGeneratorServices
    {
        Task<string> GenerateAnswer(string prompt);
    }
}
