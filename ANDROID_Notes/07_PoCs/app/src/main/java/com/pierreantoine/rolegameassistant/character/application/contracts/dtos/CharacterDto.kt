// File CharacterDto.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.application.contracts.dtos

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.ability.AbilityScoresDto
import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background.BackgroundDto
import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.basic_info.BasicInfoDto
import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.skills.SkillsDto

/**
 *   Class "CharacterDto" :
 *   Used to transmit information between application and domain.
 **/
class CharacterDto (

    val id:Int?,
    var basicInfo:BasicInfoDto?,
    var characteristics:CharacteristicsDto?,
    var background: BackgroundDto?,
    var abilityScores:AbilityScoresDto?,
    var health:HealthDto?,
    var skills:SkillsDto?
)