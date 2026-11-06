using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9280;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9280Controller : CrudApiController<TABLE9280Dto, CreateTABLE9280Dto, UpdateTABLE9280Dto, int>
{
    public TABLE9280Controller(ITABLE9280Service service) : base(service, dto => dto.NCOINS_TYPE) { }
}
