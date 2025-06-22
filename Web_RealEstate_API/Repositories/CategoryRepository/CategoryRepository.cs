using Dapper;
using Web_RealEstate_API.DTOs.CategoryDTOs;
using Web_RealEstate_API.Models.DapperContext;

namespace Web_RealEstate_API.Repositories.CategoryRepository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly Context _context;

        public CategoryRepository(Context context)
        {
            _context = context;
        }

        public async Task<IEnumerable<ResultCategoryDTO>> GetAllCategoriesAsync()
        {
            string query = "SELECT * FROM Category";
            using (var connection = _context.CreateConnection())
            {
                var values = await connection.QueryAsync<ResultCategoryDTO>(query);
                return values.ToList();
            }
        }
    }
}
