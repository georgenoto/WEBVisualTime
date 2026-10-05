using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5590;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5590Service : IService<TABLE5590Dto, CreateTABLE5590Dto, UpdateTABLE5590Dto, int>
{
    Task<IEnumerable<TABLE5590Dto>> FindAsync(Expression<Func<TABLE5590, bool>> predicate);
}
