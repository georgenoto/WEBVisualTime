using WEBVisualTime.Servicios.Insudb.DTOs.TABLE4;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE4Controller : CatalogController<TABLE4Dto, CreateTABLE4Dto, UpdateTABLE4Dto, int>
{
    public TABLE4Controller(ITABLE4Service service)
        : base(service, "TABLE4", "NBILL_ITEM", new[] { "NBILL_ITEM", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
