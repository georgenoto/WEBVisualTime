using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5591;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5591Controller : CatalogController<TABLE5591Dto, CreateTABLE5591Dto, UpdateTABLE5591Dto, int>
{
    public TABLE5591Controller(ITABLE5591Service service)
        : base(service, "TABLE5591", "NCARDINAL", new[] { "NCARDINAL", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
