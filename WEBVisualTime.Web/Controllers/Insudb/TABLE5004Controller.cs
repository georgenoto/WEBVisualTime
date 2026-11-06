using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5004;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5004Controller : CatalogController<TABLE5004Dto, CreateTABLE5004Dto, UpdateTABLE5004Dto, int>
{
    public TABLE5004Controller(ITABLE5004Service service)
        : base(service, "TABLE5004", "NSTATUS", new[] { "NSTATUS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
