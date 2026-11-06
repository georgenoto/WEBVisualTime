using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5007;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5007Controller : CatalogController<TABLE5007Dto, CreateTABLE5007Dto, UpdateTABLE5007Dto, string>
{
    public TABLE5007Controller(ITABLE5007Service service)
        : base(service, "TABLE5007", "SINDTYPTOT", new[] { "SINDTYPTOT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
