using WEBVisualTime.Servicios.Insudb.DTOs.TABLE239;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE239Controller : CatalogController<TABLE239Dto, CreateTABLE239Dto, UpdateTABLE239Dto, int>
{
    public TABLE239Controller(ITABLE239Service service)
        : base(service, "TABLE239", "NUBICATION", new[] { "NUBICATION", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
