// File AbilityScoreMapper.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper

import com.pierreantoine.rolegameassistant.character.domain.aggregate.ability.AbilityScoreModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_ability.DBAbilityScore

/**
 *   Interface "AbilityScoreMapper" :
 *   TODO: Fill interface use.
 **/
interface AbilityScoreMapper {
    fun map(abilityScore: AbilityScoreModel?):DBAbilityScore?

}