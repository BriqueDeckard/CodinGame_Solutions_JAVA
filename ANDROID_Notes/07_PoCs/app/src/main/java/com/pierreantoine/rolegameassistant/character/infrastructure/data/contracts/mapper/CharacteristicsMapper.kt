// File CharacteristicsMapper.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.DBCharacteristics
import com.pierreantoine.rolegameassistant.character.domain.aggregate.CharacteristicsModel

/**
 *   Interface "CharacteristicsMapper" :
 *   TODO: Fill interface use.
 **/
interface CharacteristicsMapper {

    fun map(characteristics: CharacteristicsModel?): DBCharacteristics?
// TODO : Fill interface.
}