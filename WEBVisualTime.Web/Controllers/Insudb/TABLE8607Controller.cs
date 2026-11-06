using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8607;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8607Controller : CatalogController<TABLE8607Dto, CreateTABLE8607Dto, UpdateTABLE8607Dto, int>
{
    public TABLE8607Controller(ITABLE8607Service service)
        : base(service, "TABLE8607", "NDOCTORROL", new[] { "NDOCTORROL", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
