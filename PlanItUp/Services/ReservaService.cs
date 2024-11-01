//using Microsoft.EntityFrameworkCore;
//using PlanItUp.Data;
//using PlanItUp.Models;
//using PlanItUp.Models.ViewModels;

//namespace PlanItUp.Services
//{
//    public class ReservaService : IReservaService
//    {
//        private readonly AppDbContext _context;

//        public ReservaService (AppDbContext context)
//        {
//            _context = context;
//        }
//        public Reserva GetReserva(int id)
//        {
//            var reserva = _context.Reserva 
//                .Include(r => r.Categoria)
//                .firstOrDefault(r => r.reservaId == id);

//            if (reserva == null)
//            {
//                return reserva;
//            }

//            return new Reserva();
//        }

//        public async Task<List<Reserva>> GetReservasDestacadas()
//        {
//            IQueryable<Reserva> reservasQuery = _context.Reservas;

//            reservasQuery = reservasQuery.Where(r => r.Activo);

//            List<Reserva> ReservasDestacadas = await reservasQuery.Take(10).ToListAsync();
//            return ReservasDestacadas;
//        }

//        public async Task<ReservasPaginadasViewModel> GetreservasPaginadas(
//            int? categoria, 
//            string? busqueda, 
//            int pagina,
//            int ReservasPorPagina
//            )
//        {
//            IQueryable<Reserva> query = _context.Reserva;
//            query = query.Where(r => r.Activo);

//                if (categoriaId.HasValue)
//                query = query.Where(r => r.ReservaId == CategoriaId);

//            if (!string.IsNullOrEmpty(busqueda))
//                query = query.Where(r => r.NombreLugar.Contains(busqueda) || r.Descripcion.Contains(busqueda)
//                );

//            int TotalReservas = await query.CountAsync();

//            int TotalPags = (int)Math.Ceiling((double)TotalReservas) /ReservasPorPagina;

//            if (pagina < 1)
//                pagina = 1; 
//            else if (pagina > TotalPags)
//                pagina = TotalPags;

//            List<Reserva> reservas = new();
//            if (TotalReservas > 0)
//            {
//                reservas = await query
//                .OrderBy(r => r.NombreLugar)
//                .Skip((pagina - 1) * ReservasPorPagina)
//                .Take(ReservasPorPagina)
//                .ToListAsync();
//            }

//            bool MostrarMensajeSinResultados = TotalReservas == 0;

//            var model = new ReservasPaginadasViewModel
//            {
//                Reservas = reservas,
//                PaginaActual = pagina,
//                TotalPaginas = TotalPags,
//                CategoriaIdSeleccionada = categoriaId,
//                Busqueda = busqueda,
//                MostrarMensajeSinResultados = MostrarMensajeSinResultados
//            };

//            return model;
//        }

//    }
//}
