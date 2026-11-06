using WEBVisualTime.Servicios.Insudb.DTOs.TABLE50;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE50Controller : CatalogController<TABLE50Dto, CreateTABLE50Dto, UpdateTABLE50Dto, string>
{
    public TABLE50Controller(ITABLE50Service service)
        : base(service, "TABLE50", "SCOLINVOT", new[] { "SCOLINVOT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
