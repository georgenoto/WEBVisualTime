using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9220;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9220Controller : CatalogController<TABLE9220Dto, CreateTABLE9220Dto, UpdateTABLE9220Dto, int>
{
    public TABLE9220Controller(ITABLE9220Service service)
        : base(service, "TABLE9220", "NINDPRINT", new[] { "NINDPRINT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
