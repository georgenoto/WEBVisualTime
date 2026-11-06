using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5540;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5540Controller : CrudApiController<TABLE5540Dto, CreateTABLE5540Dto, UpdateTABLE5540Dto, int>
{
    public TABLE5540Controller(ITABLE5540Service service) : base(service, dto => dto.NSECTOR_TYPE) { }
}
