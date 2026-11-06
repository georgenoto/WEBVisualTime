using WEBVisualTime.Servicios.Insudb.DTOs.TABLE85;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE85Controller : CatalogController<TABLE85Dto, CreateTABLE85Dto, UpdateTABLE85Dto, int>
{
    public TABLE85Controller(ITABLE85Service service)
        : base(service, "TABLE85", "NLANGUAGE", new[] { "NLANGUAGE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
