using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9264;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9264Controller : CatalogController<TABLE9264Dto, CreateTABLE9264Dto, UpdateTABLE9264Dto, int>
{
    public TABLE9264Controller(ITABLE9264Service service)
        : base(service, "TABLE9264", "NSTATORDER_MAST", new[] { "NSTATORDER_MAST", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
