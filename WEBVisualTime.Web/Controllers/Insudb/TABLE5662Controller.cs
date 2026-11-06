using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5662;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5662Controller : CatalogController<TABLE5662Dto, CreateTABLE5662Dto, UpdateTABLE5662Dto, int>
{
    public TABLE5662Controller(ITABLE5662Service service)
        : base(service, "TABLE5662", "NTYPE_COMM", new[] { "NTYPE_COMM", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
