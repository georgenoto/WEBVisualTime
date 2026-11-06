using WEBVisualTime.Servicios.Insudb.DTOs.TABLE62;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE62Controller : CrudApiController<TABLE62Dto, CreateTABLE62Dto, UpdateTABLE62Dto, int>
{
    public TABLE62Controller(ITABLE62Service service) : base(service, dto => dto.NRECTYPE) { }
}
