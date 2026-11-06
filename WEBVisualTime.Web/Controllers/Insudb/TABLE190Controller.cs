using WEBVisualTime.Servicios.Insudb.DTOs.TABLE190;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE190Controller : CatalogController<TABLE190Dto, CreateTABLE190Dto, UpdateTABLE190Dto, int>
{
    public TABLE190Controller(ITABLE190Service service)
        : base(service, "TABLE190", "NACC_TYPE", new[] { "NACC_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
