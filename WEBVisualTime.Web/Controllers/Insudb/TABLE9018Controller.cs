using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9018;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9018Controller : CatalogController<TABLE9018Dto, CreateTABLE9018Dto, UpdateTABLE9018Dto, int>
{
    public TABLE9018Controller(ITABLE9018Service service)
        : base(service, "TABLE9018", "NREFLAW", new[] { "NREFLAW", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
