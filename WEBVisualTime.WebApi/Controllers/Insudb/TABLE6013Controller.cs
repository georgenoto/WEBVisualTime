using WEBVisualTime.Servicios.Insudb.DTOs.TABLE6013;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE6013Controller : CrudApiController<TABLE6013Dto, CreateTABLE6013Dto, UpdateTABLE6013Dto, int>
{
    public TABLE6013Controller(ITABLE6013Service service) : base(service, dto => dto.NUNIT) { }
}
