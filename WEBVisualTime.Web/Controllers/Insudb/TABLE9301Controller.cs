using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9301;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9301Controller : CatalogController<TABLE9301Dto, CreateTABLE9301Dto, UpdateTABLE9301Dto, int>
{
    public TABLE9301Controller(ITABLE9301Service service)
        : base(service, "TABLE9301", "NPROMISSORYSTAT", new[] { "NPROMISSORYSTAT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
