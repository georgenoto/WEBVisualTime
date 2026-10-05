using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5679;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITABLE5679Service : IService<TABLE5679Dto, CreateTABLE5679Dto, UpdateTABLE5679Dto, int>
{
    Task<IEnumerable<TABLE5679Dto>> FindAsync(Expression<Func<TABLE5679, bool>> predicate);
}
