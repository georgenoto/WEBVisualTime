using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.TARIF_COLUMN;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class TARIF_COLUMNService : CrudService<TARIF_COLUMN, TARIF_COLUMNDto, CreateTARIF_COLUMNDto, UpdateTARIF_COLUMNDto, int>, ITARIF_COLUMNService
{
    public TARIF_COLUMNService(IRepository<TARIF_COLUMN> repository)
        : base(repository, TARIF_COLUMNMappingExtensions.ToDto, TARIF_COLUMNMappingExtensions.ToEntity, TARIF_COLUMNMappingExtensions.UpdateEntity) { }
}
