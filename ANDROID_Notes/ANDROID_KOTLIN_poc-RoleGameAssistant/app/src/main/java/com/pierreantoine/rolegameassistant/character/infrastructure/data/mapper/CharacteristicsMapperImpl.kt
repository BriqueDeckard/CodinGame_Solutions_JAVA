// File CharacteristicsMapperImpl.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.DBCharacteristics
import com.pierreantoine.rolegameassistant.character.domain.aggregate.CharacteristicsModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.CharacteristicsMapper

/**
 *   Class "CharacteristicsMapperImpl" :
 *   TODO: Fill class use.
 **/
class CharacteristicsMapperImpl : CharacteristicsMapper {
    override fun map(characteristics: CharacteristicsModel?): DBCharacteristics? {
        return DBCharacteristics(
            dbCharacteristics_id = null,
            dbCharacteristics_weight = characteristics?.weight,
            dbCharacteristics_height = characteristics?.height,
            dbCharacteristics_gender = characteristics?.gender,
            dbCharacteristics_age = characteristics?.age
        )
    }
}