// File AbilityScoreMapperImp.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper

import com.pierreantoine.rolegameassistant.character.domain.aggregate.ability.AbilityScoreModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.AbilityScoreMapper
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_ability.DBAbilityScore

/**
 *   Class "AbilityScoreMapperImp" :
 *   TODO: Fill class use.
 **/
class AbilityScoreMapperImpl : AbilityScoreMapper {

    override fun map(abilityScore: AbilityScoreModel?): DBAbilityScore? {

       return DBAbilityScore(
           dbAbilityScore_id = abilityScore?.id,
           dbAbilityScore_ability = abilityScore?.ability,
           dbAbilityScore_bonus = abilityScore?.bonus,
           dbAbilityScore_roll = abilityScore?.roll,
           dbAbilityScore_total = abilityScore?.total
       )
    }
// TODO : Fill class.
}