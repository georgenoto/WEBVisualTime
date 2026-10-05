using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CG_DES_FORM_HELP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICG_DES_FORM_HELPService : IService<CG_DES_FORM_HELPDto, CreateCG_DES_FORM_HELPDto, UpdateCG_DES_FORM_HELPDto, string>
{
    Task<IEnumerable<CG_DES_FORM_HELPDto>> FindAsync(Expression<Func<CG_DES_FORM_HELP, bool>> predicate);
}
