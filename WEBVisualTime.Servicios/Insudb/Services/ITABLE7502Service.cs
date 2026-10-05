using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7502;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7502Service : IService<TABLE7502Dto, CreateTABLE7502Dto, UpdateTABLE7502Dto, string>
{
    Task<IEnumerable<TABLE7502Dto>> FindAsync(Expression<Func<TABLE7502, bool>> predicate);
}
