using WEBVisualTime.Servicios.Insudb.DTOs.ODWA_HELP_NODES;
using WEBVisualTime.Servicios.Insudb.Services;
using WEBVisualTime.Web.Controllers.Common;

namespace WEBVisualTime.Web.Insudb.Controllers;

public class ODWA_HELP_NODESController : CatalogController<ODWA_HELP_NODESDto, CreateODWA_HELP_NODESDto, UpdateODWA_HELP_NODESDto, int>
{
    public ODWA_HELP_NODESController(IODWA_HELP_NODESService service)
        : base(service, "ODWA_HELP_NODES", "ID", new[] { "ID", "PARENT_NODE", "SEQ_IN_PARENT", "TREE_LEVEL", "DISPLAY_LABEL", "HIM_ID" }) { }
}
