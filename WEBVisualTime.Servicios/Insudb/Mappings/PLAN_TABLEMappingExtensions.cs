using WEBVisualTime.Entidades.Insudb;
using WEBVisualTime.Servicios.Insudb.DTOs.PLAN_TABLE;

namespace WEBVisualTime.Servicios.Insudb.Mappings;

public static class PLAN_TABLEMappingExtensions
{
    public static PLAN_TABLEDto ToDto(this PLAN_TABLE entity)
    {
        if (entity == null) return null!;
        return new PLAN_TABLEDto
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
            OPTIMIZER = entity.OPTIMIZER,
            SEARCH_COLUMNS = entity.SEARCH_COLUMNS,
            ID = entity.ID,
            PARENT_ID = entity.PARENT_ID,
            POSITION = entity.POSITION,
            COST = entity.COST,
            CARDINALITY = entity.CARDINALITY,
            BYTES = entity.BYTES,
            OTHER_TAG = entity.OTHER_TAG,
            PARTITION_START = entity.PARTITION_START,
            PARTITION_STOP = entity.PARTITION_STOP,
            PARTITION_ID = entity.PARTITION_ID,
            OTHER = entity.OTHER,
            DISTRIBUTION = entity.DISTRIBUTION,
        };
    }

    public static PLAN_TABLE ToEntity(this CreatePLAN_TABLEDto dto)
    {
        if (dto == null) return null!;
        return new PLAN_TABLE
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
            OPTIMIZER = dto.OPTIMIZER,
            SEARCH_COLUMNS = dto.SEARCH_COLUMNS,
            ID = dto.ID,
            PARENT_ID = dto.PARENT_ID,
            POSITION = dto.POSITION,
            COST = dto.COST,
            CARDINALITY = dto.CARDINALITY,
            BYTES = dto.BYTES,
            OTHER_TAG = dto.OTHER_TAG,
            PARTITION_START = dto.PARTITION_START,
            PARTITION_STOP = dto.PARTITION_STOP,
            PARTITION_ID = dto.PARTITION_ID,
            OTHER = dto.OTHER,
            DISTRIBUTION = dto.DISTRIBUTION,
        };
    }

    public static void UpdateEntity(this PLAN_TABLE entity, UpdatePLAN_TABLEDto dto)
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
        entity.OPTIMIZER = dto.OPTIMIZER;
        entity.SEARCH_COLUMNS = dto.SEARCH_COLUMNS;
        entity.ID = dto.ID;
        entity.PARENT_ID = dto.PARENT_ID;
        entity.POSITION = dto.POSITION;
        entity.COST = dto.COST;
        entity.CARDINALITY = dto.CARDINALITY;
        entity.BYTES = dto.BYTES;
        entity.OTHER_TAG = dto.OTHER_TAG;
        entity.PARTITION_START = dto.PARTITION_START;
        entity.PARTITION_STOP = dto.PARTITION_STOP;
        entity.PARTITION_ID = dto.PARTITION_ID;
        entity.OTHER = dto.OTHER;
        entity.DISTRIBUTION = dto.DISTRIBUTION;
    }
}
