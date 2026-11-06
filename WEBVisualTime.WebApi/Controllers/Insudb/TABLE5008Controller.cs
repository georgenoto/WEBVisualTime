using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5008;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5008Controller : CrudApiController<TABLE5008Dto, CreateTABLE5008Dto, UpdateTABLE5008Dto, long>
{
    public TABLE5008Controller(ITABLE5008Service service) : base(service, dto => dto.NCODIGINT) { }
}
