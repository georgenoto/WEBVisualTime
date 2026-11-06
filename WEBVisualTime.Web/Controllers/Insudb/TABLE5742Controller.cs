using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5742;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5742Controller : CatalogController<TABLE5742Dto, CreateTABLE5742Dto, UpdateTABLE5742Dto, int>
{
    public TABLE5742Controller(ITABLE5742Service service)
        : base(service, "TABLE5742", "NTYPE_SAAPV", new[] { "NTYPE_SAAPV", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
