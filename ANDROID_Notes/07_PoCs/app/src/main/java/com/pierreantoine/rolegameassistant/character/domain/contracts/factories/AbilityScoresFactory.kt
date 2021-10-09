// File AbilityScoresFactory.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.contracts.factories

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.ability.AbilityScoresDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.ability.AbilityScoresModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.Factory

/**
 *   Interface "AbilityScoresFactory" :
 *   Used to convert AbilityScoresDto into domain model and domain model into dto
 **/
interface AbilityScoresFactory
    : Factory<AbilityScoresDto, AbilityScoresModel> {

    /**
     * Converts dto to domain model.
     */
    override fun toDomain(dto: AbilityScoresDto?):AbilityScoresModel?

    /**
     * Converts domain model to dto.
     */
    override fun toDto(domainModel: AbilityScoresModel?):AbilityScoresDto?
}