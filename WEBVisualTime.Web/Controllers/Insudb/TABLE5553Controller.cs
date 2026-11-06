using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5553;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5553Controller : CatalogController<TABLE5553Dto, CreateTABLE5553Dto, UpdateTABLE5553Dto, int>
{
    public TABLE5553Controller(ITABLE5553Service service)
        : base(service, "TABLE5553", "NCHEQUELOCAT", new[] { "NCHEQUELOCAT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
