using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5707;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5707Controller : CatalogController<TABLE5707Dto, CreateTABLE5707Dto, UpdateTABLE5707Dto, int>
{
    public TABLE5707Controller(ITABLE5707Service service)
        : base(service, "TABLE5707", "NINTERTYPE", new[] { "NINTERTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
