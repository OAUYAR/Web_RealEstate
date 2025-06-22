using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Web_RealEstate_API.DTOs.CategoryDTOs;
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

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CreateCategoryDTO createCategoryDTO)
        {
            _categoryRepository.CreateCategory(createCategoryDTO);
            return Ok("Kategori başarılı bir şekilde eklendi.");
        }
    }
}
