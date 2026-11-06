using WEBVisualTime.Servicios.Insudb.DTOs.TABLE1014;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE1014Controller : CatalogController<TABLE1014Dto, CreateTABLE1014Dto, UpdateTABLE1014Dto, int>
{
    public TABLE1014Controller(ITABLE1014Service service)
        : base(service, "TABLE1014", "NKEYNUM", new[] { "NKEYNUM", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
