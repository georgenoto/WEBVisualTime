using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5552;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5552Service : IService<TABLE5552Dto, CreateTABLE5552Dto, UpdateTABLE5552Dto, int>
{
    Task<IEnumerable<TABLE5552Dto>> FindAsync(Expression<Func<TABLE5552, bool>> predicate);
}
