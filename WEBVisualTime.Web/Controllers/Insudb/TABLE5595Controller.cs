using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5595;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5595Controller : CatalogController<TABLE5595Dto, CreateTABLE5595Dto, UpdateTABLE5595Dto, int>
{
    public TABLE5595Controller(ITABLE5595Service service)
        : base(service, "TABLE5595", "NELECPROT", new[] { "NELECPROT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
