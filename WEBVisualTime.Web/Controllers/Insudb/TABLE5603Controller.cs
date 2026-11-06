using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5603;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5603Controller : CatalogController<TABLE5603Dto, CreateTABLE5603Dto, UpdateTABLE5603Dto, int>
{
    public TABLE5603Controller(ITABLE5603Service service)
        : base(service, "TABLE5603", "NAREAWAIT", new[] { "NAREAWAIT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
