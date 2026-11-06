using WEBVisualTime.Servicios.Insudb.DTOs.TABLE149;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE149Controller : CrudApiController<TABLE149Dto, CreateTABLE149Dto, UpdateTABLE149Dto, int>
{
    public TABLE149Controller(ITABLE149Service service) : base(service, dto => dto.NHOUSE_TYPE) { }
}
