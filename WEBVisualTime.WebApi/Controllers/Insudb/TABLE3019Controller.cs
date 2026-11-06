using WEBVisualTime.Servicios.Insudb.DTOs.TABLE3019;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE3019Controller : CrudApiController<TABLE3019Dto, CreateTABLE3019Dto, UpdateTABLE3019Dto, int>
{
    public TABLE3019Controller(ITABLE3019Service service) : base(service, dto => dto.NRECOWNER) { }
}
