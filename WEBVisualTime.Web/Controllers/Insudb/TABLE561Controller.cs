using WEBVisualTime.Servicios.Insudb.DTOs.TABLE561;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE561Controller : CatalogController<TABLE561Dto, CreateTABLE561Dto, UpdateTABLE561Dto, int>
{
    public TABLE561Controller(ITABLE561Service service)
        : base(service, "TABLE561", "NEVALSTAT", new[] { "NEVALSTAT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
