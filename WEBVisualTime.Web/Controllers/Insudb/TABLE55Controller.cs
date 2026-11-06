using WEBVisualTime.Servicios.Insudb.DTOs.TABLE55;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE55Controller : CatalogController<TABLE55Dto, CreateTABLE55Dto, UpdateTABLE55Dto, int>
{
    public TABLE55Controller(ITABLE55Service service)
        : base(service, "TABLE55", "NRELATION", new[] { "NRELATION", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
