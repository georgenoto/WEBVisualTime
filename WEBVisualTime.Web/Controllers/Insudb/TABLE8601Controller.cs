using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8601;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8601Controller : CatalogController<TABLE8601Dto, CreateTABLE8601Dto, UpdateTABLE8601Dto, string>
{
    public TABLE8601Controller(ITABLE8601Service service)
        : base(service, "TABLE8601", "SBENEFITCLAS", new[] { "SBENEFITCLAS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
