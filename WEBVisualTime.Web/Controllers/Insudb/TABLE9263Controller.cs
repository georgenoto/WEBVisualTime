using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9263;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9263Controller : CatalogController<TABLE9263Dto, CreateTABLE9263Dto, UpdateTABLE9263Dto, int>
{
    public TABLE9263Controller(ITABLE9263Service service)
        : base(service, "TABLE9263", "NNULLCODE", new[] { "NNULLCODE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
