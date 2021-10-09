// File Character.kt
// @Author errei - 16/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.aggregate

import com.pierreantoine.rolegameassistant.character.domain.aggregate.ability.AbilityScoresModel
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.BackgroundModel
import com.pierreantoine.rolegameassistant.character.domain.aggregate.basic_info.BasicInfoModel
import com.pierreantoine.rolegameassistant.character.domain.aggregate.skills.SkillsModel

/**
 *   Class "Character" :
 *   Aggregate's root entity. used to store character information by grouping children entities.
 **/
data class CharacterModel(
    var id: Int?,
    var basicInfo: BasicInfoModel?,
    var characteristics: CharacteristicsModel?,
    var background: BackgroundModel?,
    var abilityScores: AbilityScoresModel?,
    var health: HealthModel?,
    var skills: SkillsModel?

)