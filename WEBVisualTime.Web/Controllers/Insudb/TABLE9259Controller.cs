using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9259;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9259Controller : CatalogController<TABLE9259Dto, CreateTABLE9259Dto, UpdateTABLE9259Dto, int>
{
    public TABLE9259Controller(ITABLE9259Service service)
        : base(service, "TABLE9259", "NCATEG_PROV", new[] { "NCATEG_PROV", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
