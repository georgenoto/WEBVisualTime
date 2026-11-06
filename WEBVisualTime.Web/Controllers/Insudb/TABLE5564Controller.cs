using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5564;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5564Controller : CatalogController<TABLE5564Dto, CreateTABLE5564Dto, UpdateTABLE5564Dto, int>
{
    public TABLE5564Controller(ITABLE5564Service service)
        : base(service, "TABLE5564", "NBILLSTAT", new[] { "NBILLSTAT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
