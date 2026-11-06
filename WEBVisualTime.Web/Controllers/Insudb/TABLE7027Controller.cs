using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7027;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7027Controller : CatalogController<TABLE7027Dto, CreateTABLE7027Dto, UpdateTABLE7027Dto, int>
{
    public TABLE7027Controller(ITABLE7027Service service)
        : base(service, "TABLE7027", "NTYPEPROV", new[] { "NTYPEPROV", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
