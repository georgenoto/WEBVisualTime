using WEBVisualTime.Servicios.Insudb.DTOs.TABLE151;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE151Controller : CatalogController<TABLE151Dto, CreateTABLE151Dto, UpdateTABLE151Dto, int>
{
    public TABLE151Controller(ITABLE151Service service)
        : base(service, "TABLE151", "NCODE_SUS", new[] { "NCODE_SUS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
