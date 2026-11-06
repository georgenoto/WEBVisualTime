using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9274;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9274Controller : CatalogController<TABLE9274Dto, CreateTABLE9274Dto, UpdateTABLE9274Dto, int>
{
    public TABLE9274Controller(ITABLE9274Service service)
        : base(service, "TABLE9274", "NNULLCODE", new[] { "NNULLCODE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
