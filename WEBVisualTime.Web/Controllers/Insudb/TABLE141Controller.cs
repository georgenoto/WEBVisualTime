using WEBVisualTime.Servicios.Insudb.DTOs.TABLE141;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE141Controller : CatalogController<TABLE141Dto, CreateTABLE141Dto, UpdateTABLE141Dto, int>
{
    public TABLE141Controller(ITABLE141Service service)
        : base(service, "TABLE141", "NEVALSTAT", new[] { "NEVALSTAT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
