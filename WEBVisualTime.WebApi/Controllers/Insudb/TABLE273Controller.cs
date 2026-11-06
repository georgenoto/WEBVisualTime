using WEBVisualTime.Servicios.Insudb.DTOs.TABLE273;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE273Controller : CrudApiController<TABLE273Dto, CreateTABLE273Dto, UpdateTABLE273Dto, int>
{
    public TABLE273Controller(ITABLE273Service service) : base(service, dto => dto.NCATEG) { }
}
