using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5594;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5594Controller : CatalogController<TABLE5594Dto, CreateTABLE5594Dto, UpdateTABLE5594Dto, int>
{
    public TABLE5594Controller(ITABLE5594Service service)
        : base(service, "TABLE5594", "NLIC_SPECIAL", new[] { "NLIC_SPECIAL", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
