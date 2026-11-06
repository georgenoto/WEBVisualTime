using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9017;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9017Controller : CatalogController<TABLE9017Dto, CreateTABLE9017Dto, UpdateTABLE9017Dto, int>
{
    public TABLE9017Controller(ITABLE9017Service service)
        : base(service, "TABLE9017", "NREFBUS", new[] { "NREFBUS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
