using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5609;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5609Controller : CatalogController<TABLE5609Dto, CreateTABLE5609Dto, UpdateTABLE5609Dto, int>
{
    public TABLE5609Controller(ITABLE5609Service service)
        : base(service, "TABLE5609", "NCLAIMCLASS", new[] { "NCLAIMCLASS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
