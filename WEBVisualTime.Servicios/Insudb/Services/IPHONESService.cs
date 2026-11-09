using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PHONES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPHONESService : IService<PHONESDto, CreatePHONESDto, UpdatePHONESDto, string>
{
    Task<IEnumerable<PHONESDto>> FindAsync(Expression<Func<PHONES, bool>> predicate);
}
