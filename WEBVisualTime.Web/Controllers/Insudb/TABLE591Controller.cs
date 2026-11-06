using WEBVisualTime.Servicios.Insudb.DTOs.TABLE591;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE591Controller : CatalogController<TABLE591Dto, CreateTABLE591Dto, UpdateTABLE591Dto, int>
{
    public TABLE591Controller(ITABLE591Service service)
        : base(service, "TABLE591", "NSTATUS_BANKAUTH", new[] { "NSTATUS_BANKAUTH", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
