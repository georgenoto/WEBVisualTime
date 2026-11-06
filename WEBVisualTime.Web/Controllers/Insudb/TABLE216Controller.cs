using WEBVisualTime.Servicios.Insudb.DTOs.TABLE216;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE216Controller : CatalogController<TABLE216Dto, CreateTABLE216Dto, UpdateTABLE216Dto, long>
{
    public TABLE216Controller(ITABLE216Service service)
        : base(service, "TABLE216", "NRECOVER_TYP", new[] { "NRECOVER_TYP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
