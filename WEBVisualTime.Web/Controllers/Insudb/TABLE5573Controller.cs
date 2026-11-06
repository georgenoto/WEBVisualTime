using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5573;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5573Controller : CatalogController<TABLE5573Dto, CreateTABLE5573Dto, UpdateTABLE5573Dto, int>
{
    public TABLE5573Controller(ITABLE5573Service service)
        : base(service, "TABLE5573", "NOBSERVATION", new[] { "NOBSERVATION", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
