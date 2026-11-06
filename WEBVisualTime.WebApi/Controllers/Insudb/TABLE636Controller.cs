using WEBVisualTime.Servicios.Insudb.DTOs.TABLE636;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE636Controller : CrudApiController<TABLE636Dto, CreateTABLE636Dto, UpdateTABLE636Dto, long>
{
    public TABLE636Controller(ITABLE636Service service) : base(service, dto => dto.NCODIGINT) { }
}
