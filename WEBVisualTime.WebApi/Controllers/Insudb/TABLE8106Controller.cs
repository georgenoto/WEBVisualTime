using WEBVisualTime.Servicios.Insudb.DTOs.TABLE8106;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE8106Controller : CrudApiController<TABLE8106Dto, CreateTABLE8106Dto, UpdateTABLE8106Dto, long>
{
    public TABLE8106Controller(ITABLE8106Service service) : base(service, dto => dto.NFIELDDATE) { }
}
