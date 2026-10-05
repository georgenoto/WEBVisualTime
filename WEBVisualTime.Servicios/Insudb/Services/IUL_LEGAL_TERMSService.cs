using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.UL_LEGAL_TERMS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IUL_LEGAL_TERMSService : IService<UL_LEGAL_TERMSDto, CreateUL_LEGAL_TERMSDto, UpdateUL_LEGAL_TERMSDto, int>
{
    Task<IEnumerable<UL_LEGAL_TERMSDto>> FindAsync(Expression<Func<UL_LEGAL_TERMS, bool>> predicate);
}
