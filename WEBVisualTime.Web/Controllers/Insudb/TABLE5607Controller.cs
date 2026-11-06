using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5607;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5607Controller : CatalogController<TABLE5607Dto, CreateTABLE5607Dto, UpdateTABLE5607Dto, int>
{
    public TABLE5607Controller(ITABLE5607Service service)
        : base(service, "TABLE5607", "NTABLETYP", new[] { "NTABLETYP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
