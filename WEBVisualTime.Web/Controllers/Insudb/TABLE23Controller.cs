using WEBVisualTime.Servicios.Insudb.DTOs.TABLE23;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE23Controller : CatalogController<TABLE23Dto, CreateTABLE23Dto, UpdateTABLE23Dto, long>
{
    public TABLE23Controller(ITABLE23Service service)
        : base(service, "TABLE23", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
