using WEBVisualTime.Servicios.Insudb.DTOs.TABLE153;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE153Controller : CatalogController<TABLE153Dto, CreateTABLE153Dto, UpdateTABLE153Dto, string>
{
    public TABLE153Controller(ITABLE153Service service)
        : base(service, "TABLE153", "SERRORTYP", new[] { "SERRORTYP", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
