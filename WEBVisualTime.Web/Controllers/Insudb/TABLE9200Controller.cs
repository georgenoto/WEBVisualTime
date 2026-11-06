using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9200;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9200Controller : CatalogController<TABLE9200Dto, CreateTABLE9200Dto, UpdateTABLE9200Dto, int>
{
    public TABLE9200Controller(ITABLE9200Service service)
        : base(service, "TABLE9200", "NDATETYPE", new[] { "NDATETYPE", "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE" }) { }
}
