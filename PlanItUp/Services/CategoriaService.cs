//using PlanItUp.Data;
//using PlanItUp.Models;
//using System.Collections.Generic;

//namespace PlanItUp.Services
//{
//    public class CategoriaService : ICategoriaService
//    {

//        private readonly AppDbContext _context;

//        public CategoriaService(AppDbContext context)
//        {
//            _context = context;
//        }
//        public async Task<List<Categoria>> GetCategorias()
//        {
//            return await _context.Categoria.toListAsync();
//        }
//    }
//}
