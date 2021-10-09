package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.background

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background.DBFlaw
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.FlawModel

interface FlawMapper {
    fun map(flawModel:FlawModel?): DBFlaw?
}