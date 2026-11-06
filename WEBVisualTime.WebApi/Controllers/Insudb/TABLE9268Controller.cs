using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9268;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9268Controller : CrudApiController<TABLE9268Dto, CreateTABLE9268Dto, UpdateTABLE9268Dto, int>
{
    public TABLE9268Controller(ITABLE9268Service service) : base(service, dto => dto.NREPTYPE) { }
}
