using WEBVisualTime.Servicios.Insudb.DTOs.TABLE297;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE297Controller : CatalogController<TABLE297Dto, CreateTABLE297Dto, UpdateTABLE297Dto, long>
{
    public TABLE297Controller(ITABLE297Service service)
        : base(service, "TABLE297", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
