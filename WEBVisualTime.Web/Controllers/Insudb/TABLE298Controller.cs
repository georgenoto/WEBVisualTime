using WEBVisualTime.Servicios.Insudb.DTOs.TABLE298;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE298Controller : CatalogController<TABLE298Dto, CreateTABLE298Dto, UpdateTABLE298Dto, int>
{
    public TABLE298Controller(ITABLE298Service service)
        : base(service, "TABLE298", "NAPLICATION", new[] { "NAPLICATION", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
