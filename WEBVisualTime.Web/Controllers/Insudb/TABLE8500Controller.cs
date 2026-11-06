using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8500;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8500Controller : CatalogController<TABLE8500Dto, CreateTABLE8500Dto, UpdateTABLE8500Dto, int>
{
    public TABLE8500Controller(ITABLE8500Service service)
        : base(service, "TABLE8500", "NTYPE_SCHCOM", new[] { "NTYPE_SCHCOM", "DCOMPDATE", "NUSERCODE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT" }) { }
}
