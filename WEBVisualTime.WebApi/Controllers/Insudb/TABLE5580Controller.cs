using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5580;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5580Controller : CrudApiController<TABLE5580Dto, CreateTABLE5580Dto, UpdateTABLE5580Dto, int>
{
    public TABLE5580Controller(ITABLE5580Service service) : base(service, dto => dto.NORIGIN) { }
}
