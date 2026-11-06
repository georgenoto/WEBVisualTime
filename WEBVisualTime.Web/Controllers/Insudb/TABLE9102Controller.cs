using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9102;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9102Controller : CatalogController<TABLE9102Dto, CreateTABLE9102Dto, UpdateTABLE9102Dto, int>
{
    public TABLE9102Controller(ITABLE9102Service service)
        : base(service, "TABLE9102", "NSHIPTYPE", new[] { "NSHIPTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
