using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9243;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9243Controller : CatalogController<TABLE9243Dto, CreateTABLE9243Dto, UpdateTABLE9243Dto, int>
{
    public TABLE9243Controller(ITABLE9243Service service)
        : base(service, "TABLE9243", "NMOVEMENT_TYPE", new[] { "NMOVEMENT_TYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
