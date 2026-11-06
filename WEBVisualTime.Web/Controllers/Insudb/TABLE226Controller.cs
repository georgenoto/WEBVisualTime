using WEBVisualTime.Servicios.Insudb.DTOs.TABLE226;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE226Controller : CatalogController<TABLE226Dto, CreateTABLE226Dto, UpdateTABLE226Dto, int>
{
    public TABLE226Controller(ITABLE226Service service)
        : base(service, "TABLE226", "NVEHTYPE", new[] { "SDESCRIPT", "SSHORT_DES", "NVEHTYPE", "SSTATREGT", "DCOMPDATE", "NUSERCODE", "SAACHCODE" }) { }
}
