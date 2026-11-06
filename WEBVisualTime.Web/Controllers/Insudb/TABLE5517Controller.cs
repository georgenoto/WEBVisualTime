using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5517;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5517Controller : CatalogController<TABLE5517Dto, CreateTABLE5517Dto, UpdateTABLE5517Dto, int>
{
    public TABLE5517Controller(ITABLE5517Service service)
        : base(service, "TABLE5517", "NTYPLOAN_MOV", new[] { "NTYPLOAN_MOV", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
