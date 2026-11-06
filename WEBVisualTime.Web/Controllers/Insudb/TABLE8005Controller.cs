using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8005;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE8005Controller : CatalogController<TABLE8005Dto, CreateTABLE8005Dto, UpdateTABLE8005Dto, int>
{
    public TABLE8005Controller(ITABLE8005Service service)
        : base(service, "TABLE8005", "NTYPETABLE", new[] { "NTYPETABLE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
