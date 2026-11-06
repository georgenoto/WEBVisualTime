using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5568;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5568Controller : CatalogController<TABLE5568Dto, CreateTABLE5568Dto, UpdateTABLE5568Dto, int>
{
    public TABLE5568Controller(ITABLE5568Service service)
        : base(service, "TABLE5568", "NSTATUS_COMM", new[] { "NSTATUS_COMM", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
