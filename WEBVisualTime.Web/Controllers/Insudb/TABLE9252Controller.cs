using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9252;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9252Controller : CatalogController<TABLE9252Dto, CreateTABLE9252Dto, UpdateTABLE9252Dto, int>
{
    public TABLE9252Controller(ITABLE9252Service service)
        : base(service, "TABLE9252", "NPAYMENT_METHOD", new[] { "NPAYMENT_METHOD", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
