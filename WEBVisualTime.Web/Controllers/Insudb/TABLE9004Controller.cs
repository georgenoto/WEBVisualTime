using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9004;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9004Controller : CatalogController<TABLE9004Dto, CreateTABLE9004Dto, UpdateTABLE9004Dto, int>
{
    public TABLE9004Controller(ITABLE9004Service service)
        : base(service, "TABLE9004", "NCLASSCLIENT", new[] { "NCLASSCLIENT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
