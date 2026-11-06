using WEBVisualTime.Servicios.Insudb.DTOs.TABLE17;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE17Controller : CrudApiController<TABLE17Dto, CreateTABLE17Dto, UpdateTABLE17Dto, long>
{
    public TABLE17Controller(ITABLE17Service service) : base(service, dto => dto.NCODIGINT) { }
}
