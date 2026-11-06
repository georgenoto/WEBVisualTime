using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9000;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.WebApi.Controllers.Common;

namespace WEBVisualTime.WebApi.Insudb.Controllers;

public class TABLE9000Controller : CrudApiController<TABLE9000Dto, CreateTABLE9000Dto, UpdateTABLE9000Dto, int>
{
    public TABLE9000Controller(ITABLE9000Service service) : base(service, dto => dto.NCOMMERGRP) { }
}
