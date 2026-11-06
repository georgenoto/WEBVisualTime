using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8206;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8206Controller : CatalogController<TABLE8206Dto, CreateTABLE8206Dto, UpdateTABLE8206Dto, int>
{
    public TABLE8206Controller(ITABLE8206Service service)
        : base(service, "TABLE8206", "NACTION", new[] { "NACTION", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "NUSERCODE", "SSTATREGT" }) { }
}
