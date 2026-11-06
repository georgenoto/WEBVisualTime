using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7502;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7502Controller : CrudApiController<TABLE7502Dto, CreateTABLE7502Dto, UpdateTABLE7502Dto, string>
{
    public TABLE7502Controller(ITABLE7502Service service) : base(service, dto => dto.SREL_TYPE) { }
}
