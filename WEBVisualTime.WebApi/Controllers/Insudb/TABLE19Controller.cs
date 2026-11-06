using WEBVisualTime.Servicios.Insudb.DTOs.TABLE19;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE19Controller : CrudApiController<TABLE19Dto, CreateTABLE19Dto, UpdateTABLE19Dto, int>
{
    public TABLE19Controller(ITABLE19Service service) : base(service, dto => dto.NSTATUS_PRE) { }
}
