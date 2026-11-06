using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9056;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9056Controller : CatalogController<TABLE9056Dto, CreateTABLE9056Dto, UpdateTABLE9056Dto, int>
{
    public TABLE9056Controller(ITABLE9056Service service)
        : base(service, "TABLE9056", "NDUPLICATEDTYPE", new[] { "NDUPLICATEDTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
