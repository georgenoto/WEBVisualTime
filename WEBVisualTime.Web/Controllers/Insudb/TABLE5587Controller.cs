using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5587;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5587Controller : CatalogController<TABLE5587Dto, CreateTABLE5587Dto, UpdateTABLE5587Dto, int>
{
    public TABLE5587Controller(ITABLE5587Service service)
        : base(service, "TABLE5587", "NCOLLECDOCTYP", new[] { "NCOLLECDOCTYP", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
