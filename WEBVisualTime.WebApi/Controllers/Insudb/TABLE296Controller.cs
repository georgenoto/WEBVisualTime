using WEBVisualTime.Servicios.Insudb.DTOs.TABLE296;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE296Controller : CrudApiController<TABLE296Dto, CreateTABLE296Dto, UpdateTABLE296Dto, int>
{
    public TABLE296Controller(ITABLE296Service service) : base(service, dto => dto.NTYPE_MOV) { }
}
