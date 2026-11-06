using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7042;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7042Controller : CatalogController<TABLE7042Dto, CreateTABLE7042Dto, UpdateTABLE7042Dto, int>
{
    public TABLE7042Controller(ITABLE7042Service service)
        : base(service, "TABLE7042", "NVEHBRAND", new[] { "NVEHBRAND", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "SAACHCODE" }) { }
}
