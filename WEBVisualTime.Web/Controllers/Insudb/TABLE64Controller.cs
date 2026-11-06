using WEBVisualTime.Servicios.Insudb.DTOs.TABLE64;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE64Controller : CatalogController<TABLE64Dto, CreateTABLE64Dto, UpdateTABLE64Dto, string>
{
    public TABLE64Controller(ITABLE64Service service)
        : base(service, "TABLE64", "SFRANTYPE", new[] { "SFRANTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
