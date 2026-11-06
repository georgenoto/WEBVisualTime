using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7201;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7201Controller : CatalogController<TABLE7201Dto, CreateTABLE7201Dto, UpdateTABLE7201Dto, int>
{
    public TABLE7201Controller(ITABLE7201Service service)
        : base(service, "TABLE7201", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
