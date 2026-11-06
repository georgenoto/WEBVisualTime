using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5636;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5636Controller : CatalogController<TABLE5636Dto, CreateTABLE5636Dto, UpdateTABLE5636Dto, int>
{
    public TABLE5636Controller(ITABLE5636Service service)
        : base(service, "TABLE5636", "NTYPE_PAYMENT", new[] { "NTYPE_PAYMENT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
