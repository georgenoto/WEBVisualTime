using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5710;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5710Controller : CatalogController<TABLE5710Dto, CreateTABLE5710Dto, UpdateTABLE5710Dto, int>
{
    public TABLE5710Controller(ITABLE5710Service service)
        : base(service, "TABLE5710", "NPERIOD", new[] { "NPERIOD", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
