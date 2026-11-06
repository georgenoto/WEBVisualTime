using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5580;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5580Controller : CatalogController<TABLE5580Dto, CreateTABLE5580Dto, UpdateTABLE5580Dto, int>
{
    public TABLE5580Controller(ITABLE5580Service service)
        : base(service, "TABLE5580", "NORIGIN", new[] { "NORIGIN", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
