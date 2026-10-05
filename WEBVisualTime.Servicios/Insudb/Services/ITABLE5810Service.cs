using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5810;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5810Service : IService<TABLE5810Dto, CreateTABLE5810Dto, UpdateTABLE5810Dto, int>
{
    Task<IEnumerable<TABLE5810Dto>> FindAsync(Expression<Func<TABLE5810, bool>> predicate);
}
