using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5552;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5552Controller : CatalogController<TABLE5552Dto, CreateTABLE5552Dto, UpdateTABLE5552Dto, int>
{
    public TABLE5552Controller(ITABLE5552Service service)
        : base(service, "TABLE5552", "NTYPECAP", new[] { "NTYPECAP", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "DCOMPDATE", "NUSERCODE" }) { }
}
