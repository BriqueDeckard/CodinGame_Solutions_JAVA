package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.background

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background.DBIdeal
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.IdealModel

interface IdealMapper {

    fun map(idealModel:IdealModel?): DBIdeal?
}