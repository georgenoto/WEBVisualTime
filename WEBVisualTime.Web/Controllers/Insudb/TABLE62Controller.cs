using WEBVisualTime.Servicios.Insudb.DTOs.TABLE62;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE62Controller : CatalogController<TABLE62Dto, CreateTABLE62Dto, UpdateTABLE62Dto, int>
{
    public TABLE62Controller(ITABLE62Service service)
        : base(service, "TABLE62", "NRECTYPE", new[] { "NRECTYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
