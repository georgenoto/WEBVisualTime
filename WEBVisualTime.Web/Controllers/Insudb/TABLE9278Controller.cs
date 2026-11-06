using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9278;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9278Controller : CatalogController<TABLE9278Dto, CreateTABLE9278Dto, UpdateTABLE9278Dto, int>
{
    public TABLE9278Controller(ITABLE9278Service service)
        : base(service, "TABLE9278", "NSUM_INSURED_TYPE", new[] { "NSUM_INSURED_TYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "DCOMPDATE" }) { }
}
