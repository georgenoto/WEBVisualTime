using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9026;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9026Controller : CatalogController<TABLE9026Dto, CreateTABLE9026Dto, UpdateTABLE9026Dto, int>
{
    public TABLE9026Controller(ITABLE9026Service service)
        : base(service, "TABLE9026", "NGROWSALES", new[] { "NGROWSALES", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
