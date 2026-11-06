using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5008;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5008Controller : CatalogController<TABLE5008Dto, CreateTABLE5008Dto, UpdateTABLE5008Dto, long>
{
    public TABLE5008Controller(ITABLE5008Service service)
        : base(service, "TABLE5008", "NCODIGINT", new[] { "NCODIGINT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
