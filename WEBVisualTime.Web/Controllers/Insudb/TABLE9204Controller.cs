using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9204;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9204Controller : CatalogController<TABLE9204Dto, CreateTABLE9204Dto, UpdateTABLE9204Dto, int>
{
    public TABLE9204Controller(ITABLE9204Service service)
        : base(service, "TABLE9204", "NSEVERITYPEP", new[] { "NSEVERITYPEP", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
