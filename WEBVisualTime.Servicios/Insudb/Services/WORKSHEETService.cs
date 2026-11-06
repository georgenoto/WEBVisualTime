using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Datos.Repositories;
using WEBVisualTime.Servicios.Insudb.DTOs.WORKSHEET;
using WEBVisualTime.Servicios.Insudb.Mappings;
using WEBVisualTime.Servicios.Services.Common;

namespace WEBVisualTime.Servicios.Insudb.Services;

public class WORKSHEETService : CrudService<WORKSHEET, WORKSHEETDto, CreateWORKSHEETDto, UpdateWORKSHEETDto, int>, IWORKSHEETService
{
    public WORKSHEETService(IRepository<WORKSHEET> repository)
        : base(repository, WORKSHEETMappingExtensions.ToDto, WORKSHEETMappingExtensions.ToEntity, WORKSHEETMappingExtensions.UpdateEntity) { }
}
