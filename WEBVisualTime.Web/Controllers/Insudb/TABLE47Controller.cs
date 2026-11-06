using WEBVisualTime.Servicios.Insudb.DTOs.TABLE47;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE47Controller : CatalogController<TABLE47Dto, CreateTABLE47Dto, UpdateTABLE47Dto, string>
{
    public TABLE47Controller(ITABLE47Service service)
        : base(service, "TABLE47", "SCOMMITYP", new[] { "SCOMMITYP", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
