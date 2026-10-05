using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.FORMATVALUES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IFORMATVALUESService : IService<FORMATVALUESDto, CreateFORMATVALUESDto, UpdateFORMATVALUESDto, int>
{
    Task<IEnumerable<FORMATVALUESDto>> FindAsync(Expression<Func<FORMATVALUES, bool>> predicate);
}
