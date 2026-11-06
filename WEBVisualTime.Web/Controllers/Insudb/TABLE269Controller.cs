using WEBVisualTime.Servicios.Insudb.DTOs.TABLE269;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE269Controller : CatalogController<TABLE269Dto, CreateTABLE269Dto, UpdateTABLE269Dto, int>
{
    public TABLE269Controller(ITABLE269Service service)
        : base(service, "TABLE269", "NDED_TYPE", new[] { "NDED_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
