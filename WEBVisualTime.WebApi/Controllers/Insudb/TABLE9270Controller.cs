using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9270;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9270Controller : CrudApiController<TABLE9270Dto, CreateTABLE9270Dto, UpdateTABLE9270Dto, long>
{
    public TABLE9270Controller(ITABLE9270Service service) : base(service, dto => dto.NCODIGINT) { }
}
