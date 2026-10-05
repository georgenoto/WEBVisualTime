using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.ATTCHAMENTFORM;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface IATTCHAMENTFORMService : IService<ATTCHAMENTFORMDto, CreateATTCHAMENTFORMDto, UpdateATTCHAMENTFORMDto, long>
{
    Task<IEnumerable<ATTCHAMENTFORMDto>> FindAsync(Expression<Func<ATTCHAMENTFORM, bool>> predicate);
}
