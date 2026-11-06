using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5673;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5673Controller : CatalogController<TABLE5673Dto, CreateTABLE5673Dto, UpdateTABLE5673Dto, int>
{
    public TABLE5673Controller(ITABLE5673Service service)
        : base(service, "TABLE5673", "NINFORTYP", new[] { "NINFORTYP", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
