using WEBVisualTime.Servicios.Insudb.DTOs.TABLE308;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE308Controller : CatalogController<TABLE308Dto, CreateTABLE308Dto, UpdateTABLE308Dto, long>
{
    public TABLE308Controller(ITABLE308Service service)
        : base(service, "TABLE308", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
