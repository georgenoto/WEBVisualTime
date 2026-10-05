using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_DOCU;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITAB_DOCUService : IService<TAB_DOCUDto, CreateTAB_DOCUDto, UpdateTAB_DOCUDto, int>
{
    Task<IEnumerable<TAB_DOCUDto>> FindAsync(Expression<Func<TAB_DOCU, bool>> predicate);
}
