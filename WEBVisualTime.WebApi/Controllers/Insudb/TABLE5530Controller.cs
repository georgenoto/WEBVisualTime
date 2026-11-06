using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5530;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5530Controller : CrudApiController<TABLE5530Dto, CreateTABLE5530Dto, UpdateTABLE5530Dto, int>
{
    public TABLE5530Controller(ITABLE5530Service service) : base(service, dto => dto.NCOMP_TYPE) { }
}
