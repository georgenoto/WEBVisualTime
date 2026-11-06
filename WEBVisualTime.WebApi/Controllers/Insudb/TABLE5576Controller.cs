using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5576;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5576Controller : CrudApiController<TABLE5576Dto, CreateTABLE5576Dto, UpdateTABLE5576Dto, int>
{
    public TABLE5576Controller(ITABLE5576Service service) : base(service, dto => dto.NCHEQUE_STAT) { }
}
