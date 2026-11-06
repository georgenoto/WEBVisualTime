using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9007;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9007Controller : CatalogController<TABLE9007Dto, CreateTABLE9007Dto, UpdateTABLE9007Dto, int>
{
    public TABLE9007Controller(ITABLE9007Service service)
        : base(service, "TABLE9007", "NMACHINECODE", new[] { "NMACHINECODE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
