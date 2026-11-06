using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5529;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5529Controller : CatalogController<TABLE5529Dto, CreateTABLE5529Dto, UpdateTABLE5529Dto, int>
{
    public TABLE5529Controller(ITABLE5529Service service)
        : base(service, "TABLE5529", "NTYPEAGREE", new[] { "NTYPEAGREE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
