using WEBVisualTime.Servicios.Insudb.DTOs.TABLE14;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE14Controller : CatalogController<TABLE14Dto, CreateTABLE14Dto, UpdateTABLE14Dto, int>
{
    public TABLE14Controller(ITABLE14Service service)
        : base(service, "TABLE14", "NCIVILSTA", new[] { "NCIVILSTA", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
