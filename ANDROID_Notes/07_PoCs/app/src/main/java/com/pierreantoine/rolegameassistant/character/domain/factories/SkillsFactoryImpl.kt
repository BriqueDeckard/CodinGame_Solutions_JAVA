// File SkillsFactoryImpl.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.factories

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.skills.SkillsDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.skills.SkillsModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.SkillsFactory

/**
 *   Class "SkillsFactoryImpl" :
 *   To Converts Skills to SkillsDto and SkillsDto into Skills
 **/
class SkillsFactoryImpl :
    SkillsFactory {
    /**
     * Converts skillsDto into skills model.
     */
    override fun toDomain(dto: SkillsDto?): SkillsModel? {
        return SkillsModel(
            id = dto?.id
        )
    }

    /**
     * Converts skills model into skills dto.
     */
    override fun toDto(domainModel: SkillsModel?): SkillsDto? {
        return SkillsDto(
            id = domainModel?.id
        )
    }
}