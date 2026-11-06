using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5545;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5545Controller : CatalogController<TABLE5545Dto, CreateTABLE5545Dto, UpdateTABLE5545Dto, int>
{
    public TABLE5545Controller(ITABLE5545Service service)
        : base(service, "TABLE5545", "NTYPELOAD", new[] { "NTYPELOAD", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
