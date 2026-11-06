using WEBVisualTime.Servicios.Insudb.DTOs.TABLE125;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE125Controller : CatalogController<TABLE125Dto, CreateTABLE125Dto, UpdateTABLE125Dto, long>
{
    public TABLE125Controller(ITABLE125Service service)
        : base(service, "TABLE125", "NVALUESTY", new[] { "NVALUESTY", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
