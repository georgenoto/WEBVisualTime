using WEBVisualTime.Servicios.Insudb.DTOs.TABLE9000;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class TABLE9000Controller : CatalogController<TABLE9000Dto, CreateTABLE9000Dto, UpdateTABLE9000Dto, int>
{
    public TABLE9000Controller(ITABLE9000Service service)
        : base(service, "TABLE9000", "NCOMMERGRP", new[] { "DCOMPDATE", "SDESCRIPT", "SSHORT_DES", "SSTATREGT", "NUSERCODE", "NCOMMERGRP" }) { }
}
