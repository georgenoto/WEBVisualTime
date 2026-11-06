using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9245;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9245Controller : CatalogController<TABLE9245Dto, CreateTABLE9245Dto, UpdateTABLE9245Dto, int>
{
    public TABLE9245Controller(ITABLE9245Service service)
        : base(service, "TABLE9245", "NACTIONTYPE", new[] { "NACTIONTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREG", "DCOMPDATE", "NUSERCODE" }) { }
}
