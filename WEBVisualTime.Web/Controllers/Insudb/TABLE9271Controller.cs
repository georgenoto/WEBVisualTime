using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9271;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9271Controller : CatalogController<TABLE9271Dto, CreateTABLE9271Dto, UpdateTABLE9271Dto, int>
{
    public TABLE9271Controller(ITABLE9271Service service)
        : base(service, "TABLE9271", "NCAUSEREOPENCL", new[] { "NCAUSEREOPENCL", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
