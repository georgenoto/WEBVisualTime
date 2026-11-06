using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5577;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5577Controller : CatalogController<TABLE5577Dto, CreateTABLE5577Dto, UpdateTABLE5577Dto, int>
{
    public TABLE5577Controller(ITABLE5577Service service)
        : base(service, "TABLE5577", "NCHEOPER_REASON", new[] { "NCHEOPER_REASON", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
