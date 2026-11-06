using WEBVisualTime.Servicios.Insudb.DTOs.TABLE275;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE275Controller : CatalogController<TABLE275Dto, CreateTABLE275Dto, UpdateTABLE275Dto, int>
{
    public TABLE275Controller(ITABLE275Service service)
        : base(service, "TABLE275", "NSTAT_DOCREQ", new[] { "NSTAT_DOCREQ", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
