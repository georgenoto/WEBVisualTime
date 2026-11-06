using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5651;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5651Controller : CatalogController<TABLE5651Dto, CreateTABLE5651Dto, UpdateTABLE5651Dto, int>
{
    public TABLE5651Controller(ITABLE5651Service service)
        : base(service, "TABLE5651", "NPREM_DET", new[] { "NPREM_DET", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
