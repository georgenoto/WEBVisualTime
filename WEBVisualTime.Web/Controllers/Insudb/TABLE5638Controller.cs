using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5638;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5638Controller : CatalogController<TABLE5638Dto, CreateTABLE5638Dto, UpdateTABLE5638Dto, int>
{
    public TABLE5638Controller(ITABLE5638Service service)
        : base(service, "TABLE5638", "NCOMPANY", new[] { "NCOMPANY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "SOWNER_BASE", "SACCESSWO" }) { }
}
