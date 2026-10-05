using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PROPERTYLIBRARY;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPROPERTYLIBRARYService : IService<PROPERTYLIBRARYDto, CreatePROPERTYLIBRARYDto, UpdatePROPERTYLIBRARYDto, int>
{
    Task<IEnumerable<PROPERTYLIBRARYDto>> FindAsync(Expression<Func<PROPERTYLIBRARY, bool>> predicate);
}
