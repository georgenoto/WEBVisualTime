using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9Controller : CatalogController<TABLE9Dto, CreateTABLE9Dto, UpdateTABLE9Dto, int>
{
    public TABLE9Controller(ITABLE9Service service)
        : base(service, "TABLE9", "NOFFICE", new[] { "NOFFICE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
