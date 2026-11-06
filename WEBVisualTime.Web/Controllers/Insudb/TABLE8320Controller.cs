using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8320;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8320Controller : CatalogController<TABLE8320Dto, CreateTABLE8320Dto, UpdateTABLE8320Dto, int>
{
    public TABLE8320Controller(ITABLE8320Service service)
        : base(service, "TABLE8320", "NTYPEPROFILE", new[] { "NTYPEPROFILE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
