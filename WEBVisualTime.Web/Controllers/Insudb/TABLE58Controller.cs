using WEBVisualTime.Servicios.Insudb.DTOs.TABLE58;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE58Controller : CatalogController<TABLE58Dto, CreateTABLE58Dto, UpdateTABLE58Dto, int>
{
    public TABLE58Controller(ITABLE58Service service)
        : base(service, "TABLE58", "NTYPE_INDEX", new[] { "NTYPE_INDEX", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "SCOMMENTS" }) { }
}
