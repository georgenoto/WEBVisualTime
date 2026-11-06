using WEBVisualTime.Servicios.Insudb.DTOs.TABLE127;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE127Controller : CatalogController<TABLE127Dto, CreateTABLE127Dto, UpdateTABLE127Dto, int>
{
    public TABLE127Controller(ITABLE127Service service)
        : base(service, "TABLE127", "NTYPE_RESERVE", new[] { "NTYPE_RESERVE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
