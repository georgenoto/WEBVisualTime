using WEBVisualTime.Servicios.Insudb.DTOs.TABLE113;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE113Controller : CatalogController<TABLE113Dto, CreateTABLE113Dto, UpdateTABLE113Dto, int>
{
    public TABLE113Controller(ITABLE113Service service)
        : base(service, "TABLE113", "NBENEFAPL", new[] { "NBENEFAPL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
