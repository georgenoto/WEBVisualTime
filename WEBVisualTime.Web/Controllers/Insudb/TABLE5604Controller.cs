using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5604;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5604Controller : CatalogController<TABLE5604Dto, CreateTABLE5604Dto, UpdateTABLE5604Dto, int>
{
    public TABLE5604Controller(ITABLE5604Service service)
        : base(service, "TABLE5604", "NWAITCL_CODE", new[] { "NWAITCL_CODE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
