using WEBVisualTime.Servicios.Insudb.DTOs.TABLE289;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE289Controller : CatalogController<TABLE289Dto, CreateTABLE289Dto, UpdateTABLE289Dto, long>
{
    public TABLE289Controller(ITABLE289Service service)
        : base(service, "TABLE289", "NCODIGINT", new[] { "NCODIGINT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
