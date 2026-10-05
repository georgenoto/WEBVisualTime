using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5594;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5594Service : IService<TABLE5594Dto, CreateTABLE5594Dto, UpdateTABLE5594Dto, int>
{
    Task<IEnumerable<TABLE5594Dto>> FindAsync(Expression<Func<TABLE5594, bool>> predicate);
}
