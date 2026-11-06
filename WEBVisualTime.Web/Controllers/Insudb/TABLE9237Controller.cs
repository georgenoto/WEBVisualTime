using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9237;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9237Controller : CatalogController<TABLE9237Dto, CreateTABLE9237Dto, UpdateTABLE9237Dto, int>
{
    public TABLE9237Controller(ITABLE9237Service service)
        : base(service, "TABLE9237", "NATTENTCHANNEL", new[] { "NATTENTCHANNEL", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
