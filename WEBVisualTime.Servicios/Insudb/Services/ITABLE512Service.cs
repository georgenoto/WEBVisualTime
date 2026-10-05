using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE512;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE512Service : IService<TABLE512Dto, CreateTABLE512Dto, UpdateTABLE512Dto, int>
{
    Task<IEnumerable<TABLE512Dto>> FindAsync(Expression<Func<TABLE512, bool>> predicate);
}
