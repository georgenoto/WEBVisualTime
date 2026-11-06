using WEBVisualTime.Servicios.Insudb.DTOs.TABLE79;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE79Controller : CatalogController<TABLE79Dto, CreateTABLE79Dto, UpdateTABLE79Dto, string>
{
    public TABLE79Controller(ITABLE79Service service)
        : base(service, "TABLE79", "SCUMULTYP", new[] { "SCUMULTYP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
