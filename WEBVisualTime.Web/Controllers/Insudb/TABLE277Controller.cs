using WEBVisualTime.Servicios.Insudb.DTOs.TABLE277;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE277Controller : CatalogController<TABLE277Dto, CreateTABLE277Dto, UpdateTABLE277Dto, int>
{
    public TABLE277Controller(ITABLE277Service service)
        : base(service, "TABLE277", "NSERVICE", new[] { "NSERVICE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
