using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9257;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9257Controller : CatalogController<TABLE9257Dto, CreateTABLE9257Dto, UpdateTABLE9257Dto, int>
{
    public TABLE9257Controller(ITABLE9257Service service)
        : base(service, "TABLE9257", "NTYPE_SERV", new[] { "NTYPE_SERV", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
