using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9001;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9001Controller : CatalogController<TABLE9001Dto, CreateTABLE9001Dto, UpdateTABLE9001Dto, int>
{
    public TABLE9001Controller(ITABLE9001Service service)
        : base(service, "TABLE9001", "NTYPE", new[] { "NTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
