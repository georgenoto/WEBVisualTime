using WEBVisualTime.Servicios.Insudb.DTOs.TABLE193;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE193Controller : CatalogController<TABLE193Dto, CreateTABLE193Dto, UpdateTABLE193Dto, string>
{
    public TABLE193Controller(ITABLE193Service service)
        : base(service, "TABLE193", "SREQUEST_TY", new[] { "SREQUEST_TY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
