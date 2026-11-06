using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9264;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9264Controller : CrudApiController<TABLE9264Dto, CreateTABLE9264Dto, UpdateTABLE9264Dto, int>
{
    public TABLE9264Controller(ITABLE9264Service service) : base(service, dto => dto.NSTATORDER_MAST) { }
}
