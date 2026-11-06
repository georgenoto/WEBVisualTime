using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5617;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5617Controller : CatalogController<TABLE5617Dto, CreateTABLE5617Dto, UpdateTABLE5617Dto, int>
{
    public TABLE5617Controller(ITABLE5617Service service)
        : base(service, "TABLE5617", "NPAYFREQCREDITCARD", new[] { "NPAYFREQCREDITCARD", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
