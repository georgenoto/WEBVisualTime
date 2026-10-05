using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.NOTIFICA_ERP;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface INOTIFICA_ERPService : IService<NOTIFICA_ERPDto, CreateNOTIFICA_ERPDto, UpdateNOTIFICA_ERPDto, string>
{
    Task<IEnumerable<NOTIFICA_ERPDto>> FindAsync(Expression<Func<NOTIFICA_ERP, bool>> predicate);
}
