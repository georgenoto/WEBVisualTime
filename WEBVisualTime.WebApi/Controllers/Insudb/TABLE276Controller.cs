using WEBVisualTime.Servicios.Insudb.DTOs.TABLE276;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE276Controller : CrudApiController<TABLE276Dto, CreateTABLE276Dto, UpdateTABLE276Dto, string>
{
    public TABLE276Controller(ITABLE276Service service) : base(service, dto => dto.STYPE_INFOR) { }
}
