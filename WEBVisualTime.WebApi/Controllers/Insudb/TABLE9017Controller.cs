using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9017;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9017Controller : CrudApiController<TABLE9017Dto, CreateTABLE9017Dto, UpdateTABLE9017Dto, int>
{
    public TABLE9017Controller(ITABLE9017Service service) : base(service, dto => dto.NREFBUS) { }
}
