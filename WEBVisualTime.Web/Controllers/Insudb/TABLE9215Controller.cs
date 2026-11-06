using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9215;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9215Controller : CatalogController<TABLE9215Dto, CreateTABLE9215Dto, UpdateTABLE9215Dto, int>
{
    public TABLE9215Controller(ITABLE9215Service service)
        : base(service, "TABLE9215", "NATTENSYSTEM", new[] { "NATTENSYSTEM", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
