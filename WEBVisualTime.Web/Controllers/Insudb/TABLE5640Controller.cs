using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5640;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5640Controller : CatalogController<TABLE5640Dto, CreateTABLE5640Dto, UpdateTABLE5640Dto, int>
{
    public TABLE5640Controller(ITABLE5640Service service)
        : base(service, "TABLE5640", "NDEFAULTDAT", new[] { "NDEFAULTDAT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
