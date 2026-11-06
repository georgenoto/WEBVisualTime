using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9277;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9277Controller : CatalogController<TABLE9277Dto, CreateTABLE9277Dto, UpdateTABLE9277Dto, int>
{
    public TABLE9277Controller(ITABLE9277Service service)
        : base(service, "TABLE9277", "NNULLCODE", new[] { "NNULLCODE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
