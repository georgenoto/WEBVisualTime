using WEBVisualTime.Servicios.Insudb.DTOs.TABLE132;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE132Controller : CatalogController<TABLE132Dto, CreateTABLE132Dto, UpdateTABLE132Dto, string>
{
    public TABLE132Controller(ITABLE132Service service)
        : base(service, "TABLE132", "SCLAIMTYP", new[] { "SCLAIMTYP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
