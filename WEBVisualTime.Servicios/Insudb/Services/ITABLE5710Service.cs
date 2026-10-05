using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5710;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5710Service : IService<TABLE5710Dto, CreateTABLE5710Dto, UpdateTABLE5710Dto, int>
{
    Task<IEnumerable<TABLE5710Dto>> FindAsync(Expression<Func<TABLE5710, bool>> predicate);
}
