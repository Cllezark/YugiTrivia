using YugiTrivia.Shared;

namespace YugiTrivia.Server.Interfaces
{
    public interface ITestRepository
    {
        Task<TriviaCard> GetRandomCard();
    }
}