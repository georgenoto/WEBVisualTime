using WEBVisualTime.Servicios.Insudb.DTOs.TABLE997;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE997Controller : CrudApiController<TABLE997Dto, CreateTABLE997Dto, UpdateTABLE997Dto, int>
{
    public TABLE997Controller(ITABLE997Service service) : base(service, dto => dto.NMODULE_ERR) { }
}
