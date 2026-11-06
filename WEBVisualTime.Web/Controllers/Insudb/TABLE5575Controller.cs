using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5575;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5575Controller : CatalogController<TABLE5575Dto, CreateTABLE5575Dto, UpdateTABLE5575Dto, int>
{
    public TABLE5575Controller(ITABLE5575Service service)
        : base(service, "TABLE5575", "NCHEOPERTYP", new[] { "NCHEOPERTYP", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
