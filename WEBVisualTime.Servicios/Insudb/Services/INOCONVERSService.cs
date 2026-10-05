using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.NOCONVERS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface INOCONVERSService : IService<NOCONVERSDto, CreateNOCONVERSDto, UpdateNOCONVERSDto, int>
{
    Task<IEnumerable<NOCONVERSDto>> FindAsync(Expression<Func<NOCONVERS, bool>> predicate);
}
