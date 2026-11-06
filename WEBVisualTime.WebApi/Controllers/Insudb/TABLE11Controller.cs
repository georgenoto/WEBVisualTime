using WEBVisualTime.Servicios.Insudb.DTOs.TABLE11;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE11Controller : CrudApiController<TABLE11Dto, CreateTABLE11Dto, UpdateTABLE11Dto, long>
{
    public TABLE11Controller(ITABLE11Service service) : base(service, dto => dto.NCODIGINT) { }
}
