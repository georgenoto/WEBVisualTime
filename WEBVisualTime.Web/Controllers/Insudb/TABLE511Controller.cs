using WEBVisualTime.Servicios.Insudb.DTOs.TABLE511;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE511Controller : CatalogController<TABLE511Dto, CreateTABLE511Dto, UpdateTABLE511Dto, string>
{
    public TABLE511Controller(ITABLE511Service service)
        : base(service, "TABLE511", "SIND_TYPE", new[] { "SIND_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
