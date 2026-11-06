using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5006;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5006Controller : CrudApiController<TABLE5006Dto, CreateTABLE5006Dto, UpdateTABLE5006Dto, int>
{
    public TABLE5006Controller(ITABLE5006Service service) : base(service, dto => dto.NPERSON_TYP) { }
}
