using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5635;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5635Service : IService<TABLE5635Dto, CreateTABLE5635Dto, UpdateTABLE5635Dto, int>
{
    Task<IEnumerable<TABLE5635Dto>> FindAsync(Expression<Func<TABLE5635, bool>> predicate);
}
