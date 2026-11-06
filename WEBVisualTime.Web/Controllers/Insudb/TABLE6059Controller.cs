using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6059;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE6059Controller : CatalogController<TABLE6059Dto, CreateTABLE6059Dto, UpdateTABLE6059Dto, int>
{
    public TABLE6059Controller(ITABLE6059Service service)
        : base(service, "TABLE6059", "NTYPE_AMEND", new[] { "NTYPE_AMEND", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
