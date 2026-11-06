using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5000;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5000Controller : CatalogController<TABLE5000Dto, CreateTABLE5000Dto, UpdateTABLE5000Dto, int>
{
    public TABLE5000Controller(ITABLE5000Service service)
        : base(service, "TABLE5000", "NBRANCH_REI", new[] { "NBRANCH_REI", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
