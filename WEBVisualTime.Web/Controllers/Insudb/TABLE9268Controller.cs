using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9268;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9268Controller : CatalogController<TABLE9268Dto, CreateTABLE9268Dto, UpdateTABLE9268Dto, int>
{
    public TABLE9268Controller(ITABLE9268Service service)
        : base(service, "TABLE9268", "NREPTYPE", new[] { "NREPTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
