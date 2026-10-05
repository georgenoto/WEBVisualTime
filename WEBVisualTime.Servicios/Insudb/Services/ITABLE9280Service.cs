using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9280;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE9280Service : IService<TABLE9280Dto, CreateTABLE9280Dto, UpdateTABLE9280Dto, int>
{
    Task<IEnumerable<TABLE9280Dto>> FindAsync(Expression<Func<TABLE9280, bool>> predicate);
}
