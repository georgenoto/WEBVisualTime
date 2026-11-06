using WEBVisualTime.Servicios.Insudb.DTOs.TABLE7230;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE7230Controller : CrudApiController<TABLE7230Dto, CreateTABLE7230Dto, UpdateTABLE7230Dto, int>
{
    public TABLE7230Controller(ITABLE7230Service service) : base(service, dto => dto.NDEDUCTIBLE_MET) { }
}
