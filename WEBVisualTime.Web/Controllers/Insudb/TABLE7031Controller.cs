using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7031;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7031Controller : CatalogController<TABLE7031Dto, CreateTABLE7031Dto, UpdateTABLE7031Dto, long>
{
    public TABLE7031Controller(ITABLE7031Service service)
        : base(service, "TABLE7031", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
