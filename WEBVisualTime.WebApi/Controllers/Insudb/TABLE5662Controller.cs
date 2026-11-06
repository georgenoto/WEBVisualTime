using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5662;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5662Controller : CrudApiController<TABLE5662Dto, CreateTABLE5662Dto, UpdateTABLE5662Dto, int>
{
    public TABLE5662Controller(ITABLE5662Service service) : base(service, dto => dto.NTYPE_COMM) { }
}
