using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5746;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5746Service : IService<TABLE5746Dto, CreateTABLE5746Dto, UpdateTABLE5746Dto, int>
{
    Task<IEnumerable<TABLE5746Dto>> FindAsync(Expression<Func<TABLE5746, bool>> predicate);
}
