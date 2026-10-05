using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_FORMS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICDI_FORMSService : IService<CDI_FORMSDto, CreateCDI_FORMSDto, UpdateCDI_FORMSDto, string>
{
    Task<IEnumerable<CDI_FORMSDto>> FindAsync(Expression<Func<CDI_FORMS, bool>> predicate);
}
