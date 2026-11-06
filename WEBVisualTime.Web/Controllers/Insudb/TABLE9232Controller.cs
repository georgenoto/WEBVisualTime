using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9232;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9232Controller : CatalogController<TABLE9232Dto, CreateTABLE9232Dto, UpdateTABLE9232Dto, int>
{
    public TABLE9232Controller(ITABLE9232Service service)
        : base(service, "TABLE9232", "NTYPE_EV_ENDOR", new[] { "NTYPE_EV_ENDOR", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
