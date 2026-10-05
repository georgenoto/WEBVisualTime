using System.Linq.Expressions;
using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.CDI_PRODUCT_FLAVOURS;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public interface ICDI_PRODUCT_FLAVOURSService : IService<CDI_PRODUCT_FLAVOURSDto, CreateCDI_PRODUCT_FLAVOURSDto, UpdateCDI_PRODUCT_FLAVOURSDto, string>
{
    Task<IEnumerable<CDI_PRODUCT_FLAVOURSDto>> FindAsync(Expression<Func<CDI_PRODUCT_FLAVOURS, bool>> predicate);
}
