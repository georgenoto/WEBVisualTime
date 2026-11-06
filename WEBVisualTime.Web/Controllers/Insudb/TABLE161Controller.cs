using WEBVisualTime.Servicios.Insudb.DTOs.TABLE161;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE161Controller : CatalogController<TABLE161Dto, CreateTABLE161Dto, UpdateTABLE161Dto, string>
{
    public TABLE161Controller(ITABLE161Service service)
        : base(service, "TABLE161", "SSTYLE_COMM", new[] { "SSTYLE_COMM", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
