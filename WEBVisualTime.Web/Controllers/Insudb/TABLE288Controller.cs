using WEBVisualTime.Servicios.Insudb.DTOs.TABLE288;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE288Controller : CatalogController<TABLE288Dto, CreateTABLE288Dto, UpdateTABLE288Dto, int>
{
    public TABLE288Controller(ITABLE288Service service)
        : base(service, "TABLE288", "NTYPE_DOC", new[] { "NTYPE_DOC", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
