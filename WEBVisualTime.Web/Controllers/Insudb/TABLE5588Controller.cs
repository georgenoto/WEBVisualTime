using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5588;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5588Controller : CatalogController<TABLE5588Dto, CreateTABLE5588Dto, UpdateTABLE5588Dto, int>
{
    public TABLE5588Controller(ITABLE5588Service service)
        : base(service, "TABLE5588", "NTRATYPEP", new[] { "NTRATYPEP", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
