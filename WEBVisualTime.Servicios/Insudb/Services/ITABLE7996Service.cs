using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7996;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE7996Service : IService<TABLE7996Dto, CreateTABLE7996Dto, UpdateTABLE7996Dto, int>
{
    Task<IEnumerable<TABLE7996Dto>> FindAsync(Expression<Func<TABLE7996, bool>> predicate);
}
