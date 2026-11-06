using WEBVisualTime.Servicios.Insudb.DTOs.TABLE138;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE138Controller : CatalogController<TABLE138Dto, CreateTABLE138Dto, UpdateTABLE138Dto, int>
{
    public TABLE138Controller(ITABLE138Service service)
        : base(service, "TABLE138", "NPAY_FORM", new[] { "NPAY_FORM", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
