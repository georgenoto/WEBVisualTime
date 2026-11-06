using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7205;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7205Controller : CatalogController<TABLE7205Dto, CreateTABLE7205Dto, UpdateTABLE7205Dto, int>
{
    public TABLE7205Controller(ITABLE7205Service service)
        : base(service, "TABLE7205", "NFI_POLICYTYPE", new[] { "NFI_POLICYTYPE", "SDESCRIPT", "SSHORT_DES", "DCOMPDATE", "NUSERCODE", "SSTATREGT" }) { }
}
