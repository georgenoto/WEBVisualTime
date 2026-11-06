using WEBVisualTime.Servicios.Insudb.DTOs.TABLE322;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE322Controller : CatalogController<TABLE322Dto, CreateTABLE322Dto, UpdateTABLE322Dto, int>
{
    public TABLE322Controller(ITABLE322Service service)
        : base(service, "TABLE322", "NCONDACTION", new[] { "NCONDACTION", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
