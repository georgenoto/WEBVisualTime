using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5542;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5542Controller : CatalogController<TABLE5542Dto, CreateTABLE5542Dto, UpdateTABLE5542Dto, int>
{
    public TABLE5542Controller(ITABLE5542Service service)
        : base(service, "TABLE5542", "NLOCK_TYPE", new[] { "NLOCK_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
