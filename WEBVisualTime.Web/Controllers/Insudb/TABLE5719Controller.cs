using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5719;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5719Controller : CatalogController<TABLE5719Dto, CreateTABLE5719Dto, UpdateTABLE5719Dto, int>
{
    public TABLE5719Controller(ITABLE5719Service service)
        : base(service, "TABLE5719", "NREASON", new[] { "NREASON", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
