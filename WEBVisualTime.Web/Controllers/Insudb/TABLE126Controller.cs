using WEBVisualTime.Servicios.Insudb.DTOs.TABLE126;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE126Controller : CatalogController<TABLE126Dto, CreateTABLE126Dto, UpdateTABLE126Dto, long>
{
    public TABLE126Controller(ITABLE126Service service)
        : base(service, "TABLE126", "NVALUESMO", new[] { "NVALUESMO", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
