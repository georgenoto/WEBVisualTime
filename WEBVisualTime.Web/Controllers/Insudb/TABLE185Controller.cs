using WEBVisualTime.Servicios.Insudb.DTOs.TABLE185;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE185Controller : CatalogController<TABLE185Dto, CreateTABLE185Dto, UpdateTABLE185Dto, int>
{
    public TABLE185Controller(ITABLE185Service service)
        : base(service, "TABLE185", "NFINANSTAT", new[] { "NFINANSTAT", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
