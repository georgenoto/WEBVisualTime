using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5544;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5544Controller : CatalogController<TABLE5544Dto, CreateTABLE5544Dto, UpdateTABLE5544Dto, int>
{
    public TABLE5544Controller(ITABLE5544Service service)
        : base(service, "TABLE5544", "NTYPCOND", new[] { "NTYPCOND", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
