using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9281;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9281Controller : CatalogController<TABLE9281Dto, CreateTABLE9281Dto, UpdateTABLE9281Dto, int>
{
    public TABLE9281Controller(ITABLE9281Service service)
        : base(service, "TABLE9281", "NSERVICE_TYPE", new[] { "NSERVICE_TYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
