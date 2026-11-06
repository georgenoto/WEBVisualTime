using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8607;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8607Controller : CrudApiController<TABLE8607Dto, CreateTABLE8607Dto, UpdateTABLE8607Dto, int>
{
    public TABLE8607Controller(ITABLE8607Service service) : base(service, dto => dto.NDOCTORROL) { }
}
