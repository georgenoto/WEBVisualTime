using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9013;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9013Controller : CatalogController<TABLE9013Dto, CreateTABLE9013Dto, UpdateTABLE9013Dto, int>
{
    public TABLE9013Controller(ITABLE9013Service service)
        : base(service, "TABLE9013", "NTYPEPRODUCT", new[] { "NTYPEPRODUCT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
