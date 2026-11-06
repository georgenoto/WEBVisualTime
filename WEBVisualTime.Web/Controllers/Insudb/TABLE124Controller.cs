using WEBVisualTime.Servicios.Insudb.DTOs.TABLE124;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE124Controller : CatalogController<TABLE124Dto, CreateTABLE124Dto, UpdateTABLE124Dto, long>
{
    public TABLE124Controller(ITABLE124Service service)
        : base(service, "TABLE124", "NPRODCLAS", new[] { "NPRODCLAS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
