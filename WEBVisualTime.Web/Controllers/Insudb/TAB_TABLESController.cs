using WEBVisualTime.Servicios.Insudb.DTOs.TAB_TABLES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TAB_TABLESController : CatalogController<TAB_TABLESDto, CreateTAB_TABLESDto, UpdateTAB_TABLESDto, string>
{
    public TAB_TABLESController(ITAB_TABLESService service)
        : base(service, "TAB_TABLES", "STAB_CODE", new[] { "STAB_CODE", "NCOUNT_ITEM", "SCODE_ITEM", "SDESC_ITEM", "NCOUNT_TABL", "SDESCRIPT", "SDS_SELECT", "SQ_VALUE", "DCOMPDATE", "NUSERCODE", "SSHOWNUM", "SINITQUERY", "SINDSP", "SKEY" }) { }
}
