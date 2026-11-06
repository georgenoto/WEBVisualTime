using WEBVisualTime.Servicios.Insudb.DTOs.TABLE108;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE108Controller : CatalogController<TABLE108Dto, CreateTABLE108Dto, UpdateTABLE108Dto, string>
{
    public TABLE108Controller(ITABLE108Service service)
        : base(service, "TABLE108", "SPERIODTYP", new[] { "SPERIODTYP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
