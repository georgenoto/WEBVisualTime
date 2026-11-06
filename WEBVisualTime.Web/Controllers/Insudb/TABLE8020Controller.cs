using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8020;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8020Controller : CatalogController<TABLE8020Dto, CreateTABLE8020Dto, UpdateTABLE8020Dto, long>
{
    public TABLE8020Controller(ITABLE8020Service service)
        : base(service, "TABLE8020", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
