using WEBVisualTime.Servicios.Insudb.DTOs.TABLE22;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE22Controller : CatalogController<TABLE22Dto, CreateTABLE22Dto, UpdateTABLE22Dto, int>
{
    public TABLE22Controller(ITABLE22Service service)
        : base(service, "TABLE22", "NCONCEPT", new[] { "NCONCEPT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
