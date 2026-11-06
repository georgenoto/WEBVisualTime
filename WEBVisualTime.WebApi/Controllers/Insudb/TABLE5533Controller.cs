using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5533;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5533Controller : CrudApiController<TABLE5533Dto, CreateTABLE5533Dto, UpdateTABLE5533Dto, int>
{
    public TABLE5533Controller(ITABLE5533Service service) : base(service, dto => dto.NPART_AUTO) { }
}
