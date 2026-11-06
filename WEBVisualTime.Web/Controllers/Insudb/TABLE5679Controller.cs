using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5679;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5679Controller : CatalogController<TABLE5679Dto, CreateTABLE5679Dto, UpdateTABLE5679Dto, int>
{
    public TABLE5679Controller(ITABLE5679Service service)
        : base(service, "TABLE5679", "NCAUSE", new[] { "NCAUSE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
