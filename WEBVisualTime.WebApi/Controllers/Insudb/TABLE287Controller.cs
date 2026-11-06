using WEBVisualTime.Servicios.Insudb.DTOs.TABLE287;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE287Controller : CrudApiController<TABLE287Dto, CreateTABLE287Dto, UpdateTABLE287Dto, long>
{
    public TABLE287Controller(ITABLE287Service service) : base(service, dto => dto.NCODIGINT) { }
}
