using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8018;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8018Controller : CrudApiController<TABLE8018Dto, CreateTABLE8018Dto, UpdateTABLE8018Dto, int>
{
    public TABLE8018Controller(ITABLE8018Service service) : base(service, dto => dto.NNOTINFORMEMAIL) { }
}
