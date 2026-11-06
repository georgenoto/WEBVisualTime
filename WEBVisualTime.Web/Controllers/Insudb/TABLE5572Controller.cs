using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5572;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5572Controller : CatalogController<TABLE5572Dto, CreateTABLE5572Dto, UpdateTABLE5572Dto, int>
{
    public TABLE5572Controller(ITABLE5572Service service)
        : base(service, "TABLE5572", "NSTATUS_EVAL", new[] { "NSTATUS_EVAL", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
