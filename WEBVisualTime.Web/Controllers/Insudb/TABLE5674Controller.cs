using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5674;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5674Controller : CatalogController<TABLE5674Dto, CreateTABLE5674Dto, UpdateTABLE5674Dto, int>
{
    public TABLE5674Controller(ITABLE5674Service service)
        : base(service, "TABLE5674", "NMAG_DAM", new[] { "NMAG_DAM", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
