using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CI_ELEMENT_TYPES;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICI_ELEMENT_TYPESService : IService<CI_ELEMENT_TYPESDto, CreateCI_ELEMENT_TYPESDto, UpdateCI_ELEMENT_TYPESDto, string>
{
    Task<IEnumerable<CI_ELEMENT_TYPESDto>> FindAsync(Expression<Func<CI_ELEMENT_TYPES, bool>> predicate);
}
