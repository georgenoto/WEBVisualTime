using WEBVisualTime.Servicios.Insudb.DTOs.TABLE3019;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE3019Controller : CatalogController<TABLE3019Dto, CreateTABLE3019Dto, UpdateTABLE3019Dto, int>
{
    public TABLE3019Controller(ITABLE3019Service service)
        : base(service, "TABLE3019", "NRECOWNER", new[] { "NRECOWNER", "DCOMPDATE", "NUSERCODE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT" }) { }
}
