using WEBVisualTime.Servicios.Insudb.DTOs.TABLE75;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE75Controller : CatalogController<TABLE75Dto, CreateTABLE75Dto, UpdateTABLE75Dto, int>
{
    public TABLE75Controller(ITABLE75Service service)
        : base(service, "TABLE75", "NBRANCH_LED", new[] { "NBRANCH_LED", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
