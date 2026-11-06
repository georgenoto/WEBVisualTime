using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8010;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8010Controller : CatalogController<TABLE8010Dto, CreateTABLE8010Dto, UpdateTABLE8010Dto, long>
{
    public TABLE8010Controller(ITABLE8010Service service)
        : base(service, "TABLE8010", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
