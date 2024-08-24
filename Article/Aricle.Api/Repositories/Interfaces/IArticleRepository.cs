namespace Aricle.Api.Repositories.Interfaces
{
    public interface IArticleRepository
    {

        List<Models.Article> GetAll();

        Models.Article? GetById(int id);

        int Delete(int id);
    }
}
