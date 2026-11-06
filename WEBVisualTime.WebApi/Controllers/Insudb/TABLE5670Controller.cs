using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5670;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5670Controller : CrudApiController<TABLE5670Dto, CreateTABLE5670Dto, UpdateTABLE5670Dto, int>
{
    public TABLE5670Controller(ITABLE5670Service service) : base(service, dto => dto.NTYP_CUMUL) { }
}
