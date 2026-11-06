using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5677;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5677Controller : CatalogController<TABLE5677Dto, CreateTABLE5677Dto, UpdateTABLE5677Dto, int>
{
    public TABLE5677Controller(ITABLE5677Service service)
        : base(service, "TABLE5677", "NREPINSURED", new[] { "NREPINSURED", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
