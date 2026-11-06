using WEBVisualTime.Servicios.Insudb.DTOs.WORKSHEET;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class WORKSHEETController : CatalogController<WORKSHEETDto, CreateWORKSHEETDto, UpdateWORKSHEETDto, int>
{
    public WORKSHEETController(IWORKSHEETService service)
        : base(service, "WORKSHEET", "NID", new[] { "NBRANCH", "NID", "NPRODUCT", "NPOLICY", "SVALUESLIST", "DCOMPDATE", "NUSERCODE", "SDESCRIPT" }) { }
}
