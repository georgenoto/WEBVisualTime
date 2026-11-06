using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9223;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9223Controller : CatalogController<TABLE9223Dto, CreateTABLE9223Dto, UpdateTABLE9223Dto, int>
{
    public TABLE9223Controller(ITABLE9223Service service)
        : base(service, "TABLE9223", "NCLASSIFICATION", new[] { "NCLASSIFICATION", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
