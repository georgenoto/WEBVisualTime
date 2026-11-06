using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8019;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8019Controller : CrudApiController<TABLE8019Dto, CreateTABLE8019Dto, UpdateTABLE8019Dto, int>
{
    public TABLE8019Controller(ITABLE8019Service service) : base(service, dto => dto.NGROUP_SAVING) { }
}
