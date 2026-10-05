using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE62;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE62Service : IService<TABLE62Dto, CreateTABLE62Dto, UpdateTABLE62Dto, int>
{
    Task<IEnumerable<TABLE62Dto>> FindAsync(Expression<Func<TABLE62, bool>> predicate);
}
