using WEBVisualTime.Servicios.Insudb.DTOs.TABLE680;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE680Controller : CatalogController<TABLE680Dto, CreateTABLE680Dto, UpdateTABLE680Dto, int>
{
    public TABLE680Controller(ITABLE680Service service)
        : base(service, "TABLE680", "NAGREE_TYP", new[] { "NAGREE_TYP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
