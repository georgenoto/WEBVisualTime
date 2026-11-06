using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7212;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7212Controller : CatalogController<TABLE7212Dto, CreateTABLE7212Dto, UpdateTABLE7212Dto, int>
{
    public TABLE7212Controller(ITABLE7212Service service)
        : base(service, "TABLE7212", "NTYPE", new[] { "NTYPE", "SDESCRIPT", "SSHORT_DES", "DCOMPDATE", "NUSERCODE", "SSTATREGT" }) { }
}
