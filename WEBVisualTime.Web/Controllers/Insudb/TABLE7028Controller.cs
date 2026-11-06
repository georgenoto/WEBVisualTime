using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7028;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7028Controller : CatalogController<TABLE7028Dto, CreateTABLE7028Dto, UpdateTABLE7028Dto, long>
{
    public TABLE7028Controller(ITABLE7028Service service)
        : base(service, "TABLE7028", "NRETURN_CODE", new[] { "NRETURN_CODE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
