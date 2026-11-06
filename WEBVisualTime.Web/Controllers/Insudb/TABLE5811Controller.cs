using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5811;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5811Controller : CatalogController<TABLE5811Dto, CreateTABLE5811Dto, UpdateTABLE5811Dto, int>
{
    public TABLE5811Controller(ITABLE5811Service service)
        : base(service, "TABLE5811", "NQAMENTACTION", new[] { "NQAMENTACTION", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
