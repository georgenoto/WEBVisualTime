using WEBVisualTime.Servicios.Insudb.DTOs.TABLE140;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE140Controller : CatalogController<TABLE140Dto, CreateTABLE140Dto, UpdateTABLE140Dto, int>
{
    public TABLE140Controller(ITABLE140Service service)
        : base(service, "TABLE140", "NOPER_TYPE", new[] { "NOPER_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
