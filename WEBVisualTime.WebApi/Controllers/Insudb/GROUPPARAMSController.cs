using WEBVisualTime.Servicios.Insudb.DTOs.GROUPPARAMS;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class GROUPPARAMSController : CrudApiController<GROUPPARAMSDto, CreateGROUPPARAMSDto, UpdateGROUPPARAMSDto, int>
{
    public GROUPPARAMSController(IGROUPPARAMSService service) : base(service, dto => dto.NLETT_GROUP) { }
}
