using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE276;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE276Service : IService<TABLE276Dto, CreateTABLE276Dto, UpdateTABLE276Dto, string>
{
    Task<IEnumerable<TABLE276Dto>> FindAsync(Expression<Func<TABLE276, bool>> predicate);
}
