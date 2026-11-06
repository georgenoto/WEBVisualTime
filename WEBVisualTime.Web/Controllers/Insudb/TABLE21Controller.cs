using WEBVisualTime.Servicios.Insudb.DTOs.TABLE21;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE21Controller : CatalogController<TABLE21Dto, CreateTABLE21Dto, UpdateTABLE21Dto, long>
{
    public TABLE21Controller(ITABLE21Service service)
        : base(service, "TABLE21", "NLEVEL", new[] { "NLEVEL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
