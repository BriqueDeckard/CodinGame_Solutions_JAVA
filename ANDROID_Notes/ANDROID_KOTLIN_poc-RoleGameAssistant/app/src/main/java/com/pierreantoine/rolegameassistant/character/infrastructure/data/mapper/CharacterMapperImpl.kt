// File CharacterMapperImpl.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper

import com.pierreantoine.rolegameassistant.character.domain.aggregate.CharacterModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.*
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.background.BackgroundMapper
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.DBCharacter

/**
 *   Class "CharacterMapperImpl" :
 *   TODO: Fill class use.
 **/
class CharacterMapperImpl(
    val basicInfoMapper: BasicInfoMapper,
    val characteristicsMapper: CharacteristicsMapper,
    val backgroundMapper: BackgroundMapper,
    val abilityScoresMapper: AbilityScoresMapper,
    val healthMapper: HealthMapper,
    val skillsMapper: SkillsMapper
) :
    CharacterMapper {
    override fun map(character: CharacterModel?): DBCharacter {
        return DBCharacter(
            character?.id,
            dbBasicInfo_id = character?.basicInfo?.id,
            dbSkills_id = character?.skills?.id,
            dbHealth_id = character?.health?.id,
            dbAbilityScores_id = character?.abilityScores?.id,
            dbBackground_id = character?.background?.id,
            dbCharacteristics = character?.characteristics?.id
        )
    }
}