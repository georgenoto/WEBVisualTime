using WEBVisualTime.Servicios.Insudb.DTOs.TABLE232;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE232Controller : CatalogController<TABLE232Dto, CreateTABLE232Dto, UpdateTABLE232Dto, int>
{
    public TABLE232Controller(ITABLE232Service service)
        : base(service, "TABLE232", "NCLASSMERCH", new[] { "NCLASSMERCH", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
