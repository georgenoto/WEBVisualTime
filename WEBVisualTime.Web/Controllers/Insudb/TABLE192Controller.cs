using WEBVisualTime.Servicios.Insudb.DTOs.TABLE192;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE192Controller : CatalogController<TABLE192Dto, CreateTABLE192Dto, UpdateTABLE192Dto, int>
{
    public TABLE192Controller(ITABLE192Service service)
        : base(service, "TABLE192", "NCL_SEQ_TRA", new[] { "NCL_SEQ_TRA", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
