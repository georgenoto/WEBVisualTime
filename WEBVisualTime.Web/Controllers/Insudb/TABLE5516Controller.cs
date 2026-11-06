using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5516;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5516Controller : CatalogController<TABLE5516Dto, CreateTABLE5516Dto, UpdateTABLE5516Dto, int>
{
    public TABLE5516Controller(ITABLE5516Service service)
        : base(service, "TABLE5516", "NMOTIVE_ITIN", new[] { "NMOTIVE_ITIN", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
