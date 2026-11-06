using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9265;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9265Controller : CrudApiController<TABLE9265Dto, CreateTABLE9265Dto, UpdateTABLE9265Dto, int>
{
    public TABLE9265Controller(ITABLE9265Service service) : base(service, dto => dto.NMASTERORDERTYPE) { }
}
