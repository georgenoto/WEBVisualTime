using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5579;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5579Controller : CatalogController<TABLE5579Dto, CreateTABLE5579Dto, UpdateTABLE5579Dto, int>
{
    public TABLE5579Controller(ITABLE5579Service service)
        : base(service, "TABLE5579", "NAUTO_PART", new[] { "NAUTO_PART", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
