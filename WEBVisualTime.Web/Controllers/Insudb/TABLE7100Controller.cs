using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7100;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7100Controller : CatalogController<TABLE7100Dto, CreateTABLE7100Dto, UpdateTABLE7100Dto, int>
{
    public TABLE7100Controller(ITABLE7100Service service)
        : base(service, "TABLE7100", "NORDERTYPE", new[] { "NORDERTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
