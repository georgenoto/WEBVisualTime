using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TAB_AU_VEH;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TAB_AU_VEHMappingExtensions
{
    public static TAB_AU_VEHDto ToDto(this TAB_AU_VEH entity)
    {
        if (entity == null) return null!;
        return new TAB_AU_VEHDto
        {
            SVEHCODE = entity.SVEHCODE,
            SDESCRIPT = entity.SDESCRIPT,
            NNATIONAL = entity.NNATIONAL,
            NVEHBRAND = entity.NVEHBRAND,
            SSTATREGT = entity.SSTATREGT,
            SVEHMODEL = entity.SVEHMODEL,
            NVEHTYPE = entity.NVEHTYPE,
            TABLE226SDESCRIPT = entity.TABLE226?.SDESCRIPT,
            DCOMPDATE = entity.DCOMPDATE,
            NUSERCODE = entity.NUSERCODE,
            NVEHPLACE = entity.NVEHPLACE,
            NVEHPMA = entity.NVEHPMA,
            NSOAP_VEHTYPE = entity.NSOAP_VEHTYPE,
            SAACHCODE = entity.SAACHCODE,
            NGROUPVEH = entity.NGROUPVEH,
        };
    }

    public static TAB_AU_VEH ToEntity(this CreateTAB_AU_VEHDto dto)
    {
        if (dto == null) return null!;
        return new TAB_AU_VEH
        {
            SDESCRIPT = dto.SDESCRIPT,
            NNATIONAL = dto.NNATIONAL,
            NVEHBRAND = dto.NVEHBRAND,
            SSTATREGT = dto.SSTATREGT,
            SVEHMODEL = dto.SVEHMODEL,
            NVEHTYPE = dto.NVEHTYPE,
            DCOMPDATE = dto.DCOMPDATE,
            NUSERCODE = dto.NUSERCODE,
            NVEHPLACE = dto.NVEHPLACE,
            NVEHPMA = dto.NVEHPMA,
            NSOAP_VEHTYPE = dto.NSOAP_VEHTYPE,
            SAACHCODE = dto.SAACHCODE,
            NGROUPVEH = dto.NGROUPVEH,
        };
    }

    public static void UpdateEntity(this TAB_AU_VEH entity, UpdateTAB_AU_VEHDto dto)
    {
        if (entity == null || dto == null) return;
        entity.SDESCRIPT = dto.SDESCRIPT;
        entity.NNATIONAL = dto.NNATIONAL;
        entity.NVEHBRAND = dto.NVEHBRAND;
        entity.SSTATREGT = dto.SSTATREGT;
        entity.SVEHMODEL = dto.SVEHMODEL;
        entity.NVEHTYPE = dto.NVEHTYPE;
        entity.DCOMPDATE = dto.DCOMPDATE;
        entity.NUSERCODE = dto.NUSERCODE;
        entity.NVEHPLACE = dto.NVEHPLACE;
        entity.NVEHPMA = dto.NVEHPMA;
        entity.NSOAP_VEHTYPE = dto.NSOAP_VEHTYPE;
        entity.SAACHCODE = dto.SAACHCODE;
        entity.NGROUPVEH = dto.NGROUPVEH;
    }
}
