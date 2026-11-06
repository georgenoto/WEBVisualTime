using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5557;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5557Controller : CrudApiController<TABLE5557Dto, CreateTABLE5557Dto, UpdateTABLE5557Dto, int>
{
    public TABLE5557Controller(ITABLE5557Service service) : base(service, dto => dto.NCONTYPE) { }
}
