using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_RealEstate_API.Repositories.CategoryRepository;

namespace Web_RealEstate_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoriesController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpGet]
        public async Task<IActionResult> CategoryList()
        {
            var values = await _categoryRepository.GetAllCategoriesAsync();
            return Ok(values);
        }
    }
}
