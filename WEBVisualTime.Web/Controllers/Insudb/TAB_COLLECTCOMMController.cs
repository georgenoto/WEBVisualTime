using WEBVisualTime.Servicios.Insudb.DTOs.TAB_COLLECTCOMM;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_COLLECTCOMMController : CatalogController<TAB_COLLECTCOMMDto, CreateTAB_COLLECTCOMMDto, UpdateTAB_COLLECTCOMMDto, int>
{
    public TAB_COLLECTCOMMController(ITAB_COLLECTCOMMService service)
        : base(service, "TAB_COLLECTCOMM", "NCODE", new[] { "NCODE", "DCOMPDATE", "NUSERCODE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT" }) { }
}
