using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5748;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5748Controller : CatalogController<TABLE5748Dto, CreateTABLE5748Dto, UpdateTABLE5748Dto, int>
{
    public TABLE5748Controller(ITABLE5748Service service)
        : base(service, "TABLE5748", "NTYPEAGE", new[] { "NTYPEAGE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
