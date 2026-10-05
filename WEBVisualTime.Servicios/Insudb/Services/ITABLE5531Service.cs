using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5531;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5531Service : IService<TABLE5531Dto, CreateTABLE5531Dto, UpdateTABLE5531Dto, int>
{
    Task<IEnumerable<TABLE5531Dto>> FindAsync(Expression<Func<TABLE5531, bool>> predicate);
}
