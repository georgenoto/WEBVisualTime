using WEBVisualTime.Servicios.Insudb.DTOs.TABLE313;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE313Controller : CrudApiController<TABLE313Dto, CreateTABLE313Dto, UpdateTABLE313Dto, int>
{
    public TABLE313Controller(ITABLE313Service service) : base(service, dto => dto.NOPERATOR) { }
}
