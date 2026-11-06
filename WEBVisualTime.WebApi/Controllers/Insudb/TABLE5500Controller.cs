using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5500;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5500Controller : CrudApiController<TABLE5500Dto, CreateTABLE5500Dto, UpdateTABLE5500Dto, int>
{
    public TABLE5500Controller(ITABLE5500Service service) : base(service, dto => dto.NSCHE_CODE) { }
}
