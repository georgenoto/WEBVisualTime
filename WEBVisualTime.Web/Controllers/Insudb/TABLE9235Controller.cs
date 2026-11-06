using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9235;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9235Controller : CatalogController<TABLE9235Dto, CreateTABLE9235Dto, UpdateTABLE9235Dto, string>
{
    public TABLE9235Controller(ITABLE9235Service service)
        : base(service, "TABLE9235", "STYPDIS_PAYPERCEN", new[] { "STYPDIS_PAYPERCEN", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
