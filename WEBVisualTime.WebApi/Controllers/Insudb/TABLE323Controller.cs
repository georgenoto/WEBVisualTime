using WEBVisualTime.Servicios.Insudb.DTOs.TABLE323;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE323Controller : CrudApiController<TABLE323Dto, CreateTABLE323Dto, UpdateTABLE323Dto, int>
{
    public TABLE323Controller(ITABLE323Service service) : base(service, dto => dto.NSEQUENCE) { }
}
