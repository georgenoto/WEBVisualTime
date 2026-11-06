using WEBVisualTime.Servicios.Insudb.DTOs.TABLE34;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE34Controller : CrudApiController<TABLE34Dto, CreateTABLE34Dto, UpdateTABLE34Dto, long>
{
    public TABLE34Controller(ITABLE34Service service) : base(service, dto => dto.NANLIFINT) { }
}
