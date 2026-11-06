using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9265;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9265Controller : CatalogController<TABLE9265Dto, CreateTABLE9265Dto, UpdateTABLE9265Dto, int>
{
    public TABLE9265Controller(ITABLE9265Service service)
        : base(service, "TABLE9265", "NMASTERORDERTYPE", new[] { "NMASTERORDERTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
