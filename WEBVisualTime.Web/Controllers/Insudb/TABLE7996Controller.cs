using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7996;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7996Controller : CatalogController<TABLE7996Dto, CreateTABLE7996Dto, UpdateTABLE7996Dto, int>
{
    public TABLE7996Controller(ITABLE7996Service service)
        : base(service, "TABLE7996", "NLOAD_TYPE", new[] { "NLOAD_TYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
