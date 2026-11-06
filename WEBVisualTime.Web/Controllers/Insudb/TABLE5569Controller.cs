using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5569;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5569Controller : CatalogController<TABLE5569Dto, CreateTABLE5569Dto, UpdateTABLE5569Dto, int>
{
    public TABLE5569Controller(ITABLE5569Service service)
        : base(service, "TABLE5569", "NTYPEISSUE", new[] { "NTYPEISSUE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
