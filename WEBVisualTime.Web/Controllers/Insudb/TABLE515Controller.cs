using WEBVisualTime.Servicios.Insudb.DTOs.TABLE515;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE515Controller : CatalogController<TABLE515Dto, CreateTABLE515Dto, UpdateTABLE515Dto, long>
{
    public TABLE515Controller(ITABLE515Service service)
        : base(service, "TABLE515", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
