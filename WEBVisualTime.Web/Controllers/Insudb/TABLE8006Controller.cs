using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8006;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8006Controller : CatalogController<TABLE8006Dto, CreateTABLE8006Dto, UpdateTABLE8006Dto, int>
{
    public TABLE8006Controller(ITABLE8006Service service)
        : base(service, "TABLE8006", "NTYPEAFEC", new[] { "NTYPEAFEC", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
