using WEBVisualTime.Servicios.Insudb.DTOs.TABLE5623;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE5623Controller : CrudApiController<TABLE5623Dto, CreateTABLE5623Dto, UpdateTABLE5623Dto, long>
{
    public TABLE5623Controller(ITABLE5623Service service) : base(service, dto => dto.NPARTICULARCLAS) { }
}
