using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5002;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5002Controller : CatalogController<TABLE5002Dto, CreateTABLE5002Dto, UpdateTABLE5002Dto, int>
{
    public TABLE5002Controller(ITABLE5002Service service)
        : base(service, "TABLE5002", "NWAY_PAY", new[] { "NWAY_PAY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
