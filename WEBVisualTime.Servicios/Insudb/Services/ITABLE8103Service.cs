using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8103;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE8103Service : IService<TABLE8103Dto, CreateTABLE8103Dto, UpdateTABLE8103Dto, int>
{
    Task<IEnumerable<TABLE8103Dto>> FindAsync(Expression<Func<TABLE8103, bool>> predicate);
}
