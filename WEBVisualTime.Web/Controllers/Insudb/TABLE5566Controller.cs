using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5566;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5566Controller : CatalogController<TABLE5566Dto, CreateTABLE5566Dto, UpdateTABLE5566Dto, int>
{
    public TABLE5566Controller(ITABLE5566Service service)
        : base(service, "TABLE5566", "NSUS_REASON", new[] { "NSUS_REASON", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
