using WEBVisualTime.Servicios.Insudb.DTOs.TABLE521;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE521Controller : CatalogController<TABLE521Dto, CreateTABLE521Dto, UpdateTABLE521Dto, int>
{
    public TABLE521Controller(ITABLE521Service service)
        : base(service, "TABLE521", "NINF_ORDER", new[] { "NINF_ORDER", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
