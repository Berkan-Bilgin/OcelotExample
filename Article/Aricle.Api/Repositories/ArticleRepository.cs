using Aricle.Api.Models;
using Aricle.Api.Repositories.Interfaces;

namespace Aricle.Api.Repositories
{
    public class ArticleRepository : List<Models.Article>, IArticleRepository
    {
        private static List<Models.Article> articles = PopulateArticles();
        private static List<Models.Article> PopulateArticles()
        {
            var articleList = new List<Models.Article>()
            {
                new Models.Article()
                {
                    Id = 1,
                    Title = "Makale 1",
                    WriterId = 1,
                    LastUpdate = DateTime.Now,
                },
                 new Models.Article()
                {
                    Id = 2,
                    Title = "Makale 2",
                    WriterId = 2,
                    LastUpdate = DateTime.Now,
                },
                  new Models.Article()
                {
                    Id = 3,
                    Title = "Makale 3",
                    WriterId = 3,
                    LastUpdate = DateTime.Now,
                }
            };
            return articleList;

        }


        public int Delete(int id)
        {
            var removedArticle = articles.SingleOrDefault(x => x.Id == id);

            if (removedArticle != null)
            {
                articles.Remove(removedArticle);
            }

            return removedArticle?.Id ?? 0; //tek satırda if else yazdıran ternary operator
        }

        public List<Article> GetAll()
        {
            return articles;
        }

        public Article? GetById(int id)
        {
            return articles.FirstOrDefault(x => x.Id == id);
        }
    }
}
