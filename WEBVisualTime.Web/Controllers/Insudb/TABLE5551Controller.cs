using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5551;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5551Controller : CatalogController<TABLE5551Dto, CreateTABLE5551Dto, UpdateTABLE5551Dto, int>
{
    public TABLE5551Controller(ITABLE5551Service service)
        : base(service, "TABLE5551", "NCOLLECTORTYPE", new[] { "NCOLLECTORTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
