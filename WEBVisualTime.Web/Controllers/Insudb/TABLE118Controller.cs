using WEBVisualTime.Servicios.Insudb.DTOs.TABLE118;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE118Controller : CatalogController<TABLE118Dto, CreateTABLE118Dto, UpdateTABLE118Dto, int>
{
    public TABLE118Controller(ITABLE118Service service)
        : base(service, "TABLE118", "NARTICLE", new[] { "NARTICLE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
