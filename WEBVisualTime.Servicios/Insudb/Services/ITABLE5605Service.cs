using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5605;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5605Service : IService<TABLE5605Dto, CreateTABLE5605Dto, UpdateTABLE5605Dto, int>
{
    Task<IEnumerable<TABLE5605Dto>> FindAsync(Expression<Func<TABLE5605, bool>> predicate);
}
