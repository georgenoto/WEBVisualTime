using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PCC004_FORM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IPCC004_FORMService : IService<PCC004_FORMDto, CreatePCC004_FORMDto, UpdatePCC004_FORMDto, long>
{
    Task<IEnumerable<PCC004_FORMDto>> FindAsync(Expression<Func<PCC004_FORM, bool>> predicate);
}
