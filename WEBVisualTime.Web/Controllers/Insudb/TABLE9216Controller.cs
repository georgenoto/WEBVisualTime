using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9216;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9216Controller : CatalogController<TABLE9216Dto, CreateTABLE9216Dto, UpdateTABLE9216Dto, int>
{
    public TABLE9216Controller(ITABLE9216Service service)
        : base(service, "TABLE9216", "NMEDICALSTAT", new[] { "NMEDICALSTAT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
