using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9014;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9014Controller : CatalogController<TABLE9014Dto, CreateTABLE9014Dto, UpdateTABLE9014Dto, int>
{
    public TABLE9014Controller(ITABLE9014Service service)
        : base(service, "TABLE9014", "NRISK", new[] { "NRISK", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
