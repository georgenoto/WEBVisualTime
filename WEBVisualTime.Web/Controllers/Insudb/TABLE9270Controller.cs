using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9270;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9270Controller : CatalogController<TABLE9270Dto, CreateTABLE9270Dto, UpdateTABLE9270Dto, long>
{
    public TABLE9270Controller(ITABLE9270Service service)
        : base(service, "TABLE9270", "NCODIGINT", new[] { "NCODIGINT", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
