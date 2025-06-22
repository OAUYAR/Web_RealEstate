using Web_RealEstate_API.DTOs.CategoryDTOs;

namespace Web_RealEstate_API.Repositories.CategoryRepository
{
    public interface ICategoryRepository
    {
        Task<IEnumerable<ResultCategoryDTO>> GetAllCategoriesAsync();
        void CreateCategory(CreateCategoryDTO createCategoryDTO);
    }
}
