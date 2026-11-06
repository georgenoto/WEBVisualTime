using WEBVisualTime.Servicios.Insudb.DTOs.TABLE697;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE697Controller : CatalogController<TABLE697Dto, CreateTABLE697Dto, UpdateTABLE697Dto, int>
{
    public TABLE697Controller(ITABLE697Service service)
        : base(service, "TABLE697", "NSHEET", new[] { "NSHEET", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
