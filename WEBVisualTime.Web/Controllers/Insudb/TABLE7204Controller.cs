using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7204;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7204Controller : CatalogController<TABLE7204Dto, CreateTABLE7204Dto, UpdateTABLE7204Dto, long>
{
    public TABLE7204Controller(ITABLE7204Service service)
        : base(service, "TABLE7204", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
