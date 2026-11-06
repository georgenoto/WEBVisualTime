using WEBVisualTime.Servicios.Insudb.DTOs.TABLE996;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE996Controller : CatalogController<TABLE996Dto, CreateTABLE996Dto, UpdateTABLE996Dto, int>
{
    public TABLE996Controller(ITABLE996Service service)
        : base(service, "TABLE996", "NSECUR_CIA", new[] { "NSECUR_CIA", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
