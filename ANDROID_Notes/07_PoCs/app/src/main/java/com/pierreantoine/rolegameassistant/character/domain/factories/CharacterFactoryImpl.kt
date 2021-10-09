// File CharacterFactoryImpl.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.factories

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.CharacterDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.CharacterModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factories.AbilityScoresFactory
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.*

/**
 *   Class "CharacterFactoryImpl" :
 *   Handles Dto / Domain conversion.
 **/
class CharacterFactoryImpl(
    private val basicInfoFactory: BasicInfoFactory?,
    private val characteristicsFactory: CharacteristicsFactory?,
    private val abilityScoresFactory: AbilityScoresFactory?,
    private val backgroundFactory: BackgroundFactory?,
    private val healthFactory: HealthFactory?,
    private val skillsFactory: SkillsFactory?


) : CharacterFactory {
    /**
     * Converts a dto into a model domain model.
     */
    override fun toDomain(dto: CharacterDto?): CharacterModel? {
        return CharacterModel(
            id = dto?.id,
            basicInfo = basicInfoFactory?.toDomain(dto?.basicInfo),
            characteristics = characteristicsFactory?.toDomain(dto?.characteristics),
            abilityScores = abilityScoresFactory?.toDomain(dto?.abilityScores),
            background = backgroundFactory?.toDomain(dto?.background),
            health = healthFactory?.toDomain(dto?.health),
            skills = skillsFactory?.toDomain(dto?.skills)

        )

    }

    /**
     * converts a domain model into a dto.
     */
    override fun toDto(domainModel: CharacterModel?): CharacterDto? {
        return CharacterDto(
            id = domainModel?.id,
            basicInfo = basicInfoFactory?.toDto(domainModel?.basicInfo),
            characteristics = characteristicsFactory?.toDto(domainModel?.characteristics),
            abilityScores = abilityScoresFactory?.toDto(domainModel?.abilityScores),
            background = backgroundFactory?.toDto(domainModel?.background),
            health = healthFactory?.toDto(domainModel?.health),
            skills = skillsFactory?.toDto(domainModel?.skills)
        )
    }
}