using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5582;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5582Controller : CatalogController<TABLE5582Dto, CreateTABLE5582Dto, UpdateTABLE5582Dto, int>
{
    public TABLE5582Controller(ITABLE5582Service service)
        : base(service, "TABLE5582", "NTYPCOND", new[] { "NTYPCOND", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
