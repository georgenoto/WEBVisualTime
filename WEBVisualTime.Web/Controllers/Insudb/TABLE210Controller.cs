using WEBVisualTime.Servicios.Insudb.DTOs.TABLE210;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE210Controller : CatalogController<TABLE210Dto, CreateTABLE210Dto, UpdateTABLE210Dto, int>
{
    public TABLE210Controller(ITABLE210Service service)
        : base(service, "TABLE210", "NCLA_LI_TYP", new[] { "NCLA_LI_TYP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
