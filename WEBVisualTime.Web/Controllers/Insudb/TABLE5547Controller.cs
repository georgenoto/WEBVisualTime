using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5547;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5547Controller : CatalogController<TABLE5547Dto, CreateTABLE5547Dto, UpdateTABLE5547Dto, int>
{
    public TABLE5547Controller(ITABLE5547Service service)
        : base(service, "TABLE5547", "NCAUSEUPD", new[] { "NCAUSEUPD", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
