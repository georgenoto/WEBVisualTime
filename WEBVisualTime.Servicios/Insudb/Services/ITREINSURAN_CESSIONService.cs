using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TREINSURAN_CESSION;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ITREINSURAN_CESSIONService : IService<TREINSURAN_CESSIONDto, CreateTREINSURAN_CESSIONDto, UpdateTREINSURAN_CESSIONDto, string>
{
    Task<IEnumerable<TREINSURAN_CESSIONDto>> FindAsync(Expression<Func<TREINSURAN_CESSION, bool>> predicate);
}
