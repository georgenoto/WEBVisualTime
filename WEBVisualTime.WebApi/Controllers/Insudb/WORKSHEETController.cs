using WEBVisualTime.Servicios.Insudb.DTOs.WORKSHEET;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class WORKSHEETController : CrudApiController<WORKSHEETDto, CreateWORKSHEETDto, UpdateWORKSHEETDto, int>
{
    public WORKSHEETController(IWORKSHEETService service) : base(service, dto => dto.NID) { }
}
