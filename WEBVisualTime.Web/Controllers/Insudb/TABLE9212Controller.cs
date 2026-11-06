using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9212;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9212Controller : CatalogController<TABLE9212Dto, CreateTABLE9212Dto, UpdateTABLE9212Dto, int>
{
    public TABLE9212Controller(ITABLE9212Service service)
        : base(service, "TABLE9212", "NCLAIMANTTYPE", new[] { "NCLAIMANTTYPE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
