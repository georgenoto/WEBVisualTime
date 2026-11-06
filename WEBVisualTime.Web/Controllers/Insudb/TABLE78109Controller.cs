using WEBVisualTime.Servicios.Insudb.DTOs.TABLE78109;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE78109Controller : CatalogController<TABLE78109Dto, CreateTABLE78109Dto, UpdateTABLE78109Dto, int>
{
    public TABLE78109Controller(ITABLE78109Service service)
        : base(service, "TABLE78109", "NSOAP_VEHTYPE", new[] { "NSOAP_VEHTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "SAACHCODE" }) { }
}
