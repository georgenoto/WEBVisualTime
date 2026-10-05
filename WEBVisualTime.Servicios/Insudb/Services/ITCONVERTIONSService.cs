using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TCONVERTIONS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITCONVERTIONSService : IService<TCONVERTIONSDto, CreateTCONVERTIONSDto, UpdateTCONVERTIONSDto, string>
{
    Task<IEnumerable<TCONVERTIONSDto>> FindAsync(Expression<Func<TCONVERTIONS, bool>> predicate);
}
