using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9006;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9006Controller : CatalogController<TABLE9006Dto, CreateTABLE9006Dto, UpdateTABLE9006Dto, int>
{
    public TABLE9006Controller(ITABLE9006Service service)
        : base(service, "TABLE9006", "NCONSTCLASS", new[] { "NCONSTCLASS", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
