using WEBVisualTime.Servicios.Insudb.DTOs.TABLE320;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE320Controller : CatalogController<TABLE320Dto, CreateTABLE320Dto, UpdateTABLE320Dto, int>
{
    public TABLE320Controller(ITABLE320Service service)
        : base(service, "TABLE320", "NOPERATOR", new[] { "NOPERATOR", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
