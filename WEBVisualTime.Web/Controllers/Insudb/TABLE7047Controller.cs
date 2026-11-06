using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7047;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7047Controller : CatalogController<TABLE7047Dto, CreateTABLE7047Dto, UpdateTABLE7047Dto, int>
{
    public TABLE7047Controller(ITABLE7047Service service)
        : base(service, "TABLE7047", "NSEISMICZONE", new[] { "NSEISMICZONE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
