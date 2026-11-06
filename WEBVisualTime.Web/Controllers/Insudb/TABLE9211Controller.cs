using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9211;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9211Controller : CatalogController<TABLE9211Dto, CreateTABLE9211Dto, UpdateTABLE9211Dto, int>
{
    public TABLE9211Controller(ITABLE9211Service service)
        : base(service, "TABLE9211", "NRETENTION", new[] { "NRETENTION", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
