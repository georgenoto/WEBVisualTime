using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5704;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5704Controller : CatalogController<TABLE5704Dto, CreateTABLE5704Dto, UpdateTABLE5704Dto, int>
{
    public TABLE5704Controller(ITABLE5704Service service)
        : base(service, "TABLE5704", "NOPERATOR", new[] { "NOPERATOR", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
