using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8106;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8106Controller : CatalogController<TABLE8106Dto, CreateTABLE8106Dto, UpdateTABLE8106Dto, long>
{
    public TABLE8106Controller(ITABLE8106Service service)
        : base(service, "TABLE8106", "NFIELDDATE", new[] { "NFIELDDATE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
