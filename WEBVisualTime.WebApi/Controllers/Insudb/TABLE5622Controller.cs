using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5622;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5622Controller : CrudApiController<TABLE5622Dto, CreateTABLE5622Dto, UpdateTABLE5622Dto, int>
{
    public TABLE5622Controller(ITABLE5622Service service) : base(service, dto => dto.NTYPEOFWORK) { }
}
