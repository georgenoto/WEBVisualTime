using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5744;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5744Controller : CrudApiController<TABLE5744Dto, CreateTABLE5744Dto, UpdateTABLE5744Dto, int>
{
    public TABLE5744Controller(ITABLE5744Service service) : base(service, dto => dto.NFUNDS_ORIGIN) { }
}
