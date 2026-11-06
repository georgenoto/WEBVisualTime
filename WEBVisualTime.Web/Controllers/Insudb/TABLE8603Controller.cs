using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8603;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8603Controller : CatalogController<TABLE8603Dto, CreateTABLE8603Dto, UpdateTABLE8603Dto, string>
{
    public TABLE8603Controller(ITABLE8603Service service)
        : base(service, "TABLE8603", "SMEDSPECIALIALTY", new[] { "SMEDSPECIALIALTY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
