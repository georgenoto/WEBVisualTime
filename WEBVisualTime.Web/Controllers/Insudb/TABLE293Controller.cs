using WEBVisualTime.Servicios.Insudb.DTOs.TABLE293;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE293Controller : CatalogController<TABLE293Dto, CreateTABLE293Dto, UpdateTABLE293Dto, int>
{
    public TABLE293Controller(ITABLE293Service service)
        : base(service, "TABLE293", "NCONCEPT", new[] { "NCONCEPT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
