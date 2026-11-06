using WEBVisualTime.Servicios.Insudb.DTOs.TABLE215;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE215Controller : CatalogController<TABLE215Dto, CreateTABLE215Dto, UpdateTABLE215Dto, int>
{
    public TABLE215Controller(ITABLE215Service service)
        : base(service, "TABLE215", "NSTATUS_ORD", new[] { "NSTATUS_ORD", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
