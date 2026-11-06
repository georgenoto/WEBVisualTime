using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9224;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9224Controller : CatalogController<TABLE9224Dto, CreateTABLE9224Dto, UpdateTABLE9224Dto, int>
{
    public TABLE9224Controller(ITABLE9224Service service)
        : base(service, "TABLE9224", "NNULLCODE", new[] { "NNULLCODE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
