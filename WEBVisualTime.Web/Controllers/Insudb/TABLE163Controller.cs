using WEBVisualTime.Servicios.Insudb.DTOs.TABLE163;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE163Controller : CatalogController<TABLE163Dto, CreateTABLE163Dto, UpdateTABLE163Dto, int>
{
    public TABLE163Controller(ITABLE163Service service)
        : base(service, "TABLE163", "NNULLCODE", new[] { "NNULLCODE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
