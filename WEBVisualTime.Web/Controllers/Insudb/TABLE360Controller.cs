using WEBVisualTime.Servicios.Insudb.DTOs.TABLE360;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE360Controller : CatalogController<TABLE360Dto, CreateTABLE360Dto, UpdateTABLE360Dto, int>
{
    public TABLE360Controller(ITABLE360Service service)
        : base(service, "TABLE360", "NTYPEATTRIBUT", new[] { "NTYPEATTRIBUT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
