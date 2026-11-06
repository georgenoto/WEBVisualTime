using WEBVisualTime.Servicios.Insudb.DTOs.TABLE533;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE533Controller : CatalogController<TABLE533Dto, CreateTABLE533Dto, UpdateTABLE533Dto, int>
{
    public TABLE533Controller(ITABLE533Service service)
        : base(service, "TABLE533", "NCONCEPT", new[] { "NCONCEPT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
