using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8060;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8060Controller : CatalogController<TABLE8060Dto, CreateTABLE8060Dto, UpdateTABLE8060Dto, long>
{
    public TABLE8060Controller(ITABLE8060Service service)
        : base(service, "TABLE8060", "NBESTTIMETOCALL", new[] { "NBESTTIMETOCALL", "DCOMPDATE", "NUSERCODE", "SSTATREGT", "SDESCRIPT", "SSHORT_DES" }) { }
}
