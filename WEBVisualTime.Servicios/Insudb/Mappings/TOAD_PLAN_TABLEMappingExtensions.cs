using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.TOAD_PLAN_TABLE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class TOAD_PLAN_TABLEMappingExtensions
{
    public static TOAD_PLAN_TABLEDto ToDto(this TOAD_PLAN_TABLE entity)
    {
        if (entity == null) return null!;
        return new TOAD_PLAN_TABLEDto
        {
            STATEMENT_ID = entity.STATEMENT_ID,
            TIMESTAMP = entity.TIMESTAMP,
            REMARKS = entity.REMARKS,
            OPERATION = entity.OPERATION,
            OPTIONS = entity.OPTIONS,
            OBJECT_NODE = entity.OBJECT_NODE,
            OBJECT_OWNER = entity.OBJECT_OWNER,
            OBJECT_NAME = entity.OBJECT_NAME,
            OBJECT_INSTANCE = entity.OBJECT_INSTANCE,
            OBJECT_TYPE = entity.OBJECT_TYPE,
            SEARCH_COLUMNS = entity.SEARCH_COLUMNS,
            ID = entity.ID,
            COST = entity.COST,
            PARENT_ID = entity.PARENT_ID,
            POSITION = entity.POSITION,
            CARDINALITY = entity.CARDINALITY,
            OPTIMIZER = entity.OPTIMIZER,
            BYTES = entity.BYTES,
            OTHER_TAG = entity.OTHER_TAG,
            PARTITION_ID = entity.PARTITION_ID,
            PARTITION_START = entity.PARTITION_START,
            PARTITION_STOP = entity.PARTITION_STOP,
            DISTRIBUTION = entity.DISTRIBUTION,
            OTHER = entity.OTHER,
        };
    }

    public static TOAD_PLAN_TABLE ToEntity(this CreateTOAD_PLAN_TABLEDto dto)
    {
        if (dto == null) return null!;
        return new TOAD_PLAN_TABLE
        {
            STATEMENT_ID = dto.STATEMENT_ID,
            TIMESTAMP = dto.TIMESTAMP,
            REMARKS = dto.REMARKS,
            OPERATION = dto.OPERATION,
            OPTIONS = dto.OPTIONS,
            OBJECT_NODE = dto.OBJECT_NODE,
            OBJECT_OWNER = dto.OBJECT_OWNER,
            OBJECT_NAME = dto.OBJECT_NAME,
            OBJECT_INSTANCE = dto.OBJECT_INSTANCE,
            OBJECT_TYPE = dto.OBJECT_TYPE,
            SEARCH_COLUMNS = dto.SEARCH_COLUMNS,
            ID = dto.ID,
            COST = dto.COST,
            PARENT_ID = dto.PARENT_ID,
            POSITION = dto.POSITION,
            CARDINALITY = dto.CARDINALITY,
            OPTIMIZER = dto.OPTIMIZER,
            BYTES = dto.BYTES,
            OTHER_TAG = dto.OTHER_TAG,
            PARTITION_ID = dto.PARTITION_ID,
            PARTITION_START = dto.PARTITION_START,
            PARTITION_STOP = dto.PARTITION_STOP,
            DISTRIBUTION = dto.DISTRIBUTION,
            OTHER = dto.OTHER,
        };
    }

    public static void UpdateEntity(this TOAD_PLAN_TABLE entity, UpdateTOAD_PLAN_TABLEDto dto)
    {
        if (entity == null || dto == null) return;
        entity.STATEMENT_ID = dto.STATEMENT_ID;
        entity.TIMESTAMP = dto.TIMESTAMP;
        entity.REMARKS = dto.REMARKS;
        entity.OPERATION = dto.OPERATION;
        entity.OPTIONS = dto.OPTIONS;
        entity.OBJECT_NODE = dto.OBJECT_NODE;
        entity.OBJECT_OWNER = dto.OBJECT_OWNER;
        entity.OBJECT_NAME = dto.OBJECT_NAME;
        entity.OBJECT_INSTANCE = dto.OBJECT_INSTANCE;
        entity.OBJECT_TYPE = dto.OBJECT_TYPE;
        entity.SEARCH_COLUMNS = dto.SEARCH_COLUMNS;
        entity.ID = dto.ID;
        entity.COST = dto.COST;
        entity.PARENT_ID = dto.PARENT_ID;
        entity.POSITION = dto.POSITION;
        entity.CARDINALITY = dto.CARDINALITY;
        entity.OPTIMIZER = dto.OPTIMIZER;
        entity.BYTES = dto.BYTES;
        entity.OTHER_TAG = dto.OTHER_TAG;
        entity.PARTITION_ID = dto.PARTITION_ID;
        entity.PARTITION_START = dto.PARTITION_START;
        entity.PARTITION_STOP = dto.PARTITION_STOP;
        entity.DISTRIBUTION = dto.DISTRIBUTION;
        entity.OTHER = dto.OTHER;
    }
}
