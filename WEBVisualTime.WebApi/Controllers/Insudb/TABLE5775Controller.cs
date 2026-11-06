using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5775;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5775Controller : CrudApiController<TABLE5775Dto, CreateTABLE5775Dto, UpdateTABLE5775Dto, int>
{
    public TABLE5775Controller(ITABLE5775Service service) : base(service, dto => dto.NTRANSACTIO) { }
}
