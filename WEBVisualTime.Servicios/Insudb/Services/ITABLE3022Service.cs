using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE3022;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE3022Service : IService<TABLE3022Dto, CreateTABLE3022Dto, UpdateTABLE3022Dto, int>
{
    Task<IEnumerable<TABLE3022Dto>> FindAsync(Expression<Func<TABLE3022, bool>> predicate);
}
