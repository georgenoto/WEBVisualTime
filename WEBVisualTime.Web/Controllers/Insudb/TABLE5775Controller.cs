using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5775;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5775Controller : CatalogController<TABLE5775Dto, CreateTABLE5775Dto, UpdateTABLE5775Dto, int>
{
    public TABLE5775Controller(ITABLE5775Service service)
        : base(service, "TABLE5775", "NTRANSACTIO", new[] { "NTRANSACTIO", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
