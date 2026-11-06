using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9250;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9250Controller : CatalogController<TABLE9250Dto, CreateTABLE9250Dto, UpdateTABLE9250Dto, int>
{
    public TABLE9250Controller(ITABLE9250Service service)
        : base(service, "TABLE9250", "NSETTLEMENT_STAT", new[] { "NSETTLEMENT_STAT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
