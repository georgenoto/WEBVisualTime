using WEBVisualTime.Servicios.Insudb.DTOs.TABLE84;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE84Controller : CatalogController<TABLE84Dto, CreateTABLE84Dto, UpdateTABLE84Dto, int>
{
    public TABLE84Controller(ITABLE84Service service)
        : base(service, "TABLE84", "NDEPARTME", new[] { "NDEPARTME", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
