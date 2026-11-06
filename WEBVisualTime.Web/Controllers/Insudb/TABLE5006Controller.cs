using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5006;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5006Controller : CatalogController<TABLE5006Dto, CreateTABLE5006Dto, UpdateTABLE5006Dto, int>
{
    public TABLE5006Controller(ITABLE5006Service service)
        : base(service, "TABLE5006", "NPERSON_TYP", new[] { "NPERSON_TYP", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
