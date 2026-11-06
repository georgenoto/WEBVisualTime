using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9022;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9022Controller : CatalogController<TABLE9022Dto, CreateTABLE9022Dto, UpdateTABLE9022Dto, int>
{
    public TABLE9022Controller(ITABLE9022Service service)
        : base(service, "TABLE9022", "NCREDITREASON", new[] { "NCREDITREASON", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
