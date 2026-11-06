using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7039;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7039Controller : CatalogController<TABLE7039Dto, CreateTABLE7039Dto, UpdateTABLE7039Dto, int>
{
    public TABLE7039Controller(ITABLE7039Service service)
        : base(service, "TABLE7039", "NBUILDTYPE", new[] { "NBUILDTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
