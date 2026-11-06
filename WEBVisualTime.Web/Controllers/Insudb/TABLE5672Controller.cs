using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5672;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5672Controller : CatalogController<TABLE5672Dto, CreateTABLE5672Dto, UpdateTABLE5672Dto, int>
{
    public TABLE5672Controller(ITABLE5672Service service)
        : base(service, "TABLE5672", "NTYPPORT", new[] { "NTYPPORT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
