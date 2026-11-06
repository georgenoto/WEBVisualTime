using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5750;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5750Controller : CatalogController<TABLE5750Dto, CreateTABLE5750Dto, UpdateTABLE5750Dto, string>
{
    public TABLE5750Controller(ITABLE5750Service service)
        : base(service, "TABLE5750", "STYPECOM", new[] { "STYPECOM", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
