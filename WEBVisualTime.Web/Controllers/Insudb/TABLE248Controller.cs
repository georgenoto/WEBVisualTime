using WEBVisualTime.Servicios.Insudb.DTOs.TABLE248;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE248Controller : CatalogController<TABLE248Dto, CreateTABLE248Dto, UpdateTABLE248Dto, int>
{
    public TABLE248Controller(ITABLE248Service service)
        : base(service, "TABLE248", "NRISK", new[] { "NRISK", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
