// File AbilityScoresMapperImpl.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_ability.DBAbilityScores
import com.pierreantoine.rolegameassistant.character.domain.aggregate.ability.AbilityScoresModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.AbilityScoresMapper

/**
 *   Class "AbilityScoresMapperImpl" :
 *   TODO: Fill class use.
 **/
class AbilityScoresMapperImpl : AbilityScoresMapper {
    override fun map(abilityScores: AbilityScoresModel?): DBAbilityScores? {
        return DBAbilityScores(
            dbAbilityScores_id = abilityScores?.id
            )
    }

// TODO : Fill class.
}