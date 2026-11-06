using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8200;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8200Controller : CatalogController<TABLE8200Dto, CreateTABLE8200Dto, UpdateTABLE8200Dto, int>
{
    public TABLE8200Controller(ITABLE8200Service service)
        : base(service, "TABLE8200", "NPROCESS", new[] { "NPROCESS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "NUSERCODE", "SSTATREGT" }) { }
}
