using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FOLDERS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IFOLDERSService : IService<FOLDERSDto, CreateFOLDERSDto, UpdateFOLDERSDto, int>
{
    Task<IEnumerable<FOLDERSDto>> FindAsync(Expression<Func<FOLDERS, bool>> predicate);
}
