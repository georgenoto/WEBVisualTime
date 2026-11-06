using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5623;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE5623Controller : CatalogController<TABLE5623Dto, CreateTABLE5623Dto, UpdateTABLE5623Dto, long>
{
    public TABLE5623Controller(ITABLE5623Service service)
        : base(service, "TABLE5623", "NPARTICULARCLAS", new[] { "NPARTICULARCLAS", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
