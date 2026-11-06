using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5670;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5670Controller : CatalogController<TABLE5670Dto, CreateTABLE5670Dto, UpdateTABLE5670Dto, int>
{
    public TABLE5670Controller(ITABLE5670Service service)
        : base(service, "TABLE5670", "NTYP_CUMUL", new[] { "NTYP_CUMUL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
