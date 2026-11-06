using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5616;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5616Controller : CatalogController<TABLE5616Dto, CreateTABLE5616Dto, UpdateTABLE5616Dto, int>
{
    public TABLE5616Controller(ITABLE5616Service service)
        : base(service, "TABLE5616", "NPAYFORMCREDITCARD", new[] { "NPAYFORMCREDITCARD", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
