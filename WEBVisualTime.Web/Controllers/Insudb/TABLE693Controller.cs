using WEBVisualTime.Servicios.Insudb.DTOs.TABLE693;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE693Controller : CatalogController<TABLE693Dto, CreateTABLE693Dto, UpdateTABLE693Dto, int>
{
    public TABLE693Controller(ITABLE693Service service)
        : base(service, "TABLE693", "NPRERECEIPT", new[] { "NPRERECEIPT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
