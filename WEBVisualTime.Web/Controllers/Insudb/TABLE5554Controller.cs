using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5554;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5554Controller : CatalogController<TABLE5554Dto, CreateTABLE5554Dto, UpdateTABLE5554Dto, int>
{
    public TABLE5554Controller(ITABLE5554Service service)
        : base(service, "TABLE5554", "NINPUTTYP", new[] { "NINPUTTYP", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
