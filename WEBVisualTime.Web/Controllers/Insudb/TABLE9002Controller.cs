using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9002;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9002Controller : CatalogController<TABLE9002Dto, CreateTABLE9002Dto, UpdateTABLE9002Dto, int>
{
    public TABLE9002Controller(ITABLE9002Service service)
        : base(service, "TABLE9002", "NMATERIA", new[] { "NMATERIA", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
