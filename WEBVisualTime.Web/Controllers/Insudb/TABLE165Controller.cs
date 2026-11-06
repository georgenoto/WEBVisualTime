using WEBVisualTime.Servicios.Insudb.DTOs.TABLE165;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE165Controller : CatalogController<TABLE165Dto, CreateTABLE165Dto, UpdateTABLE165Dto, int>
{
    public TABLE165Controller(ITABLE165Service service)
        : base(service, "TABLE165", "NTYPE_HIST", new[] { "NTYPE_HIST", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
