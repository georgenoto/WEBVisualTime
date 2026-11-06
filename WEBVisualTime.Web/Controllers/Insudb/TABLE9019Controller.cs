using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9019;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9019Controller : CatalogController<TABLE9019Dto, CreateTABLE9019Dto, UpdateTABLE9019Dto, int>
{
    public TABLE9019Controller(ITABLE9019Service service)
        : base(service, "TABLE9019", "NNUMPAYS", new[] { "NNUMPAYS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
