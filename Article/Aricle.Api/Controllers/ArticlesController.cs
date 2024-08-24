using Aricle.Api.Repositories.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Aricle.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {

        private IArticleRepository articleRepository;

        public ArticlesController(IArticleRepository articleRepository)
        {
            this.articleRepository = articleRepository;
        }

        [HttpGet]
        public IActionResult GetArticles()
        {
            return Ok(articleRepository.GetAll());
        }

        [HttpGet("{id}")]
        public IActionResult GetArticleDetails(int id)
        {
            var articleDetails = articleRepository.GetById(id);

            if (articleDetails == null)
            {
                return NotFound();
            }

            return Ok(articleDetails);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteArticle(int id)
        {
            var deletedArticle = articleRepository.Delete(id);

            if (deletedArticle == 0)
            {
                return NotFound();
            }

            return NoContent();
        }
    }
}
