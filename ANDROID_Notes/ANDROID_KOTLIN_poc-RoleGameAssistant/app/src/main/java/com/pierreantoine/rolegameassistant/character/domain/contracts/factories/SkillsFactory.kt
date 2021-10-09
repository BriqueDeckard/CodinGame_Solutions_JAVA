// File SkillsFactory.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.contracts.factory

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.skills.SkillsDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.skills.SkillsModel

/**
 *   Interface "SkillsFactory" :
 *   Converts dto to domain model.
 *   Converts domain model to dto.
 **/
interface SkillsFactory : Factory<SkillsDto, SkillsModel> {
    /**
     * Converts dto to domain model.
     */
    override fun toDomain(dto: SkillsDto?): SkillsModel?
    /**
     * Converts domain model to dto.
     */
    override fun toDto(domainModel: SkillsModel?): SkillsDto?
}