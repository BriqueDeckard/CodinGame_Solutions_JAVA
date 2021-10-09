// File AbilityScoresMapper.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_ability.DBAbilityScores
import com.pierreantoine.rolegameassistant.character.domain.aggregate.ability.AbilityScoresModel

/**
 *   Interface "AbilityScoresMapper" :
 *   TODO: Fill interface use.
 **/
interface AbilityScoresMapper {
    fun map(abilityScores: AbilityScoresModel?):DBAbilityScores?
// TODO : Fill interface.
}