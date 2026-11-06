using WEBVisualTime.Servicios.Insudb.DTOs.TABLE415;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE415Controller : CatalogController<TABLE415Dto, CreateTABLE415Dto, UpdateTABLE415Dto, int>
{
    public TABLE415Controller(ITABLE415Service service)
        : base(service, "TABLE415", "NMOVE_TYPE", new[] { "NMOVE_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
