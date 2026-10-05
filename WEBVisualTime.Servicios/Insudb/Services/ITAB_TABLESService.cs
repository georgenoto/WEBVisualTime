using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_TABLES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_TABLESService : IService<TAB_TABLESDto, CreateTAB_TABLESDto, UpdateTAB_TABLESDto, string>
{
    Task<IEnumerable<TAB_TABLESDto>> FindAsync(Expression<Func<TAB_TABLES, bool>> predicate);
}
