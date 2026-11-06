using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5703;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5703Controller : CatalogController<TABLE5703Dto, CreateTABLE5703Dto, UpdateTABLE5703Dto, int>
{
    public TABLE5703Controller(ITABLE5703Service service)
        : base(service, "TABLE5703", "NOBJTYPE", new[] { "NOBJTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
