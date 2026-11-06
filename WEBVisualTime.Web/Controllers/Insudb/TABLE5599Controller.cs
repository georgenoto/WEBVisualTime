using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5599;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5599Controller : CatalogController<TABLE5599Dto, CreateTABLE5599Dto, UpdateTABLE5599Dto, int>
{
    public TABLE5599Controller(ITABLE5599Service service)
        : base(service, "TABLE5599", "NILLUSTTYPE", new[] { "NILLUSTTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
