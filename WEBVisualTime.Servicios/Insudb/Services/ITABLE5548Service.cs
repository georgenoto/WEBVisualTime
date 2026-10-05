using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5548;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5548Service : IService<TABLE5548Dto, CreateTABLE5548Dto, UpdateTABLE5548Dto, int>
{
    Task<IEnumerable<TABLE5548Dto>> FindAsync(Expression<Func<TABLE5548, bool>> predicate);
}
