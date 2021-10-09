// File CharacterMapper.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.DBCharacter
import com.pierreantoine.rolegameassistant.character.domain.aggregate.CharacterModel

/**
 *   Class "CharacterMapper" :
 *   TODO: Fill class use.
 **/
interface CharacterMapper {

    fun map(character: CharacterModel?): DBCharacter?
// TODO : Fill class.
}