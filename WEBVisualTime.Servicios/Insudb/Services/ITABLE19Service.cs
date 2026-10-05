using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE19;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE19Service : IService<TABLE19Dto, CreateTABLE19Dto, UpdateTABLE19Dto, int>
{
    Task<IEnumerable<TABLE19Dto>> FindAsync(Expression<Func<TABLE19, bool>> predicate);
}
