using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5586;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5586Service : IService<TABLE5586Dto, CreateTABLE5586Dto, UpdateTABLE5586Dto, int>
{
    Task<IEnumerable<TABLE5586Dto>> FindAsync(Expression<Func<TABLE5586, bool>> predicate);
}
