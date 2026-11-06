using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5596;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5596Controller : CatalogController<TABLE5596Dto, CreateTABLE5596Dto, UpdateTABLE5596Dto, int>
{
    public TABLE5596Controller(ITABLE5596Service service)
        : base(service, "TABLE5596", "NMATERPIPE", new[] { "NMATERPIPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
