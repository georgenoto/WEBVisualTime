using WEBVisualTime.Servicios.Insudb.DTOs.TABLE99;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE99Controller : CatalogController<TABLE99Dto, CreateTABLE99Dto, UpdateTABLE99Dto, int>
{
    public TABLE99Controller(ITABLE99Service service)
        : base(service, "TABLE99", "NTYPE_LETTER", new[] { "NTYPE_LETTER", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
