using WEBVisualTime.Servicios.Insudb.DTOs.TABLE52;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE52Controller : CatalogController<TABLE52Dto, CreateTABLE52Dto, UpdateTABLE52Dto, string>
{
    public TABLE52Controller(ITABLE52Service service)
        : base(service, "TABLE52", "SCAREN_TYPE", new[] { "SCAREN_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
