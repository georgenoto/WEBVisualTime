using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9260;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9260Controller : CatalogController<TABLE9260Dto, CreateTABLE9260Dto, UpdateTABLE9260Dto, int>
{
    public TABLE9260Controller(ITABLE9260Service service)
        : base(service, "TABLE9260", "NPROCTYPEREN", new[] { "NPROCTYPEREN", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
