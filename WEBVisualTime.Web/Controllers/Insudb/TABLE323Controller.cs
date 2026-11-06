using WEBVisualTime.Servicios.Insudb.DTOs.TABLE323;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE323Controller : CatalogController<TABLE323Dto, CreateTABLE323Dto, UpdateTABLE323Dto, int>
{
    public TABLE323Controller(ITABLE323Service service)
        : base(service, "TABLE323", "NSEQUENCE", new[] { "NSEQUENCE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
