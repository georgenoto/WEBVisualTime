using WEBVisualTime.Servicios.Insudb.DTOs.TABLE256;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE256Controller : CatalogController<TABLE256Dto, CreateTABLE256Dto, UpdateTABLE256Dto, long>
{
    public TABLE256Controller(ITABLE256Service service)
        : base(service, "TABLE256", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
