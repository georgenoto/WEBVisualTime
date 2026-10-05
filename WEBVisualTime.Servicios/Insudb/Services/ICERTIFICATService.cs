using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CERTIFICAT;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICERTIFICATService : IService<CERTIFICATDto, CreateCERTIFICATDto, UpdateCERTIFICATDto, string>
{
    Task<IEnumerable<CERTIFICATDto>> FindAsync(Expression<Func<CERTIFICAT, bool>> predicate);
}
