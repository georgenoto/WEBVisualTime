using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9101;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9101Controller : CatalogController<TABLE9101Dto, CreateTABLE9101Dto, UpdateTABLE9101Dto, int>
{
    public TABLE9101Controller(ITABLE9101Service service)
        : base(service, "TABLE9101", "NMATERIAL", new[] { "NMATERIAL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
