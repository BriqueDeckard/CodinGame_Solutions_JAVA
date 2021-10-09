package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper

import com.pierreantoine.rolegameassistant.character.domain.aggregate.basic_info.RaceModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_basic_info.DBRace

interface RaceMapper {
    fun map(classModel: RaceModel?):DBRace //    TODO : Implements mapping
}