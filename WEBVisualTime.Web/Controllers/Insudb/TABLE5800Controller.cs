using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5800;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5800Controller : CatalogController<TABLE5800Dto, CreateTABLE5800Dto, UpdateTABLE5800Dto, int>
{
    public TABLE5800Controller(ITABLE5800Service service)
        : base(service, "TABLE5800", "NID_TABLE", new[] { "NID_TABLE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
