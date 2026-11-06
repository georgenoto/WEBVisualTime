using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5745;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5745Controller : CatalogController<TABLE5745Dto, CreateTABLE5745Dto, UpdateTABLE5745Dto, string>
{
    public TABLE5745Controller(ITABLE5745Service service)
        : base(service, "TABLE5745", "SAFP_TYPE", new[] { "SAFP_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
