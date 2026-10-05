using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.LIFE_DOCU;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ILIFE_DOCUService : IService<LIFE_DOCUDto, CreateLIFE_DOCUDto, UpdateLIFE_DOCUDto, string>
{
    Task<IEnumerable<LIFE_DOCUDto>> FindAsync(Expression<Func<LIFE_DOCU, bool>> predicate);
}
