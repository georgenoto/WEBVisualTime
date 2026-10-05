using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.NOTES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface INOTESService : IService<NOTESDto, CreateNOTESDto, UpdateNOTESDto, long>
{
    Task<IEnumerable<NOTESDto>> FindAsync(Expression<Func<NOTES, bool>> predicate);
}
