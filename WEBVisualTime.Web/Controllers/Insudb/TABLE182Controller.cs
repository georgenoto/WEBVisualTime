using WEBVisualTime.Servicios.Insudb.DTOs.TABLE182;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE182Controller : CatalogController<TABLE182Dto, CreateTABLE182Dto, UpdateTABLE182Dto, string>
{
    public TABLE182Controller(ITABLE182Service service)
        : base(service, "TABLE182", "SPAY_FORM", new[] { "SPAY_FORM", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
