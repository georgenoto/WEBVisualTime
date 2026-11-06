using WEBVisualTime.Servicios.Insudb.DTOs.TABLE680;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE680Controller : CrudApiController<TABLE680Dto, CreateTABLE680Dto, UpdateTABLE680Dto, int>
{
    public TABLE680Controller(ITABLE680Service service) : base(service, dto => dto.NAGREE_TYP) { }
}
