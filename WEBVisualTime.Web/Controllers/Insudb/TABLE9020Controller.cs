using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9020;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9020Controller : CatalogController<TABLE9020Dto, CreateTABLE9020Dto, UpdateTABLE9020Dto, int>
{
    public TABLE9020Controller(ITABLE9020Service service)
        : base(service, "TABLE9020", "NOLDINSURANCE", new[] { "NOLDINSURANCE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
