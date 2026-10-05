using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROVINCE;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPROVINCEService : IService<PROVINCEDto, CreatePROVINCEDto, UpdatePROVINCEDto, int>
{
    Task<IEnumerable<PROVINCEDto>> FindAsync(Expression<Func<PROVINCE, bool>> predicate);
}
