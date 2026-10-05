using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.USERS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IUSERSService : IService<USERSDto, CreateUSERSDto, UpdateUSERSDto, int>
{
    Task<IEnumerable<USERSDto>> FindAsync(Expression<Func<USERS, bool>> predicate);
}
