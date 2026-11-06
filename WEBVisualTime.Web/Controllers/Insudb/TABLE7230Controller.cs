using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7230;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE7230Controller : CatalogController<TABLE7230Dto, CreateTABLE7230Dto, UpdateTABLE7230Dto, int>
{
    public TABLE7230Controller(ITABLE7230Service service)
        : base(service, "TABLE7230", "NDEDUCTIBLE_MET", new[] { "NDEDUCTIBLE_MET", "SDESCRIPT", "SSHORT_DES", "DCOMPDATE", "NUSERCODE", "SSTATREGT" }) { }
}
