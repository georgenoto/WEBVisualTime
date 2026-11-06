using WEBVisualTime.Servicios.Insudb.DTOs.TABLE41;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE41Controller : CatalogController<TABLE41Dto, CreateTABLE41Dto, UpdateTABLE41Dto, long>
{
    public TABLE41Controller(ITABLE41Service service)
        : base(service, "TABLE41", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
