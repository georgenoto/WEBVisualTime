using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8205;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8205Controller : CatalogController<TABLE8205Dto, CreateTABLE8205Dto, UpdateTABLE8205Dto, int>
{
    public TABLE8205Controller(ITABLE8205Service service)
        : base(service, "TABLE8205", "NSECTION", new[] { "NSECTION", "SDESCRIPT", "SSHORT_DES", "DCOMPDATE", "NUSERCODE", "SSTATREGT" }) { }
}
