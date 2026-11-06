using WEBVisualTime.Servicios.Insudb.DTOs.DISEX_INT_M;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class DISEX_INT_MController : CatalogController<DISEX_INT_MDto, CreateDISEX_INT_MDto, UpdateDISEX_INT_MDto, int>
{
    public DISEX_INT_MController(IDISEX_INT_MService service)
        : base(service, "DISEX_INT_M", "NECO_SCHE", new[] { "NECO_SCHE", "SDESCRIPT", "DCOMPDATE", "NUSERCODE", "SSHORT_DES", "SSTATREGT" }) { }
}
