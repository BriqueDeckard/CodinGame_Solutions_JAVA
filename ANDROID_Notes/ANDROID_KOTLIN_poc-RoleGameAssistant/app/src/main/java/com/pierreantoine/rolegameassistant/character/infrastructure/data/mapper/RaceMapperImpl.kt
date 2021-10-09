// File RaceMapper.kt
// @Author errei - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper

import com.pierreantoine.rolegameassistant.character.domain.aggregate.basic_info.RaceModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.RaceMapper
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_basic_info.DBRace

/**
 *   Class "RaceMapper" :
 *   TODO: Fill class use.
 **/
class RaceMapperImpl : RaceMapper {
    override fun map(classModel: RaceModel?): DBRace {
        return DBRace(
            dbRace_id = null,
            dbRace_name = classModel?.name
        )
    }
// TODO : Fill class.
}