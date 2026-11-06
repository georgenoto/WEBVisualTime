using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5586;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5586Controller : CatalogController<TABLE5586Dto, CreateTABLE5586Dto, UpdateTABLE5586Dto, int>
{
    public TABLE5586Controller(ITABLE5586Service service)
        : base(service, "TABLE5586", "NDEFERRED", new[] { "NDEFERRED", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
