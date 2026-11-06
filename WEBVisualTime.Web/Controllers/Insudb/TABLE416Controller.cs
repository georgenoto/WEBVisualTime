using WEBVisualTime.Servicios.Insudb.DTOs.TABLE416;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE416Controller : CatalogController<TABLE416Dto, CreateTABLE416Dto, UpdateTABLE416Dto, long>
{
    public TABLE416Controller(ITABLE416Service service)
        : base(service, "TABLE416", "NCONCEPT", new[] { "NCONCEPT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
