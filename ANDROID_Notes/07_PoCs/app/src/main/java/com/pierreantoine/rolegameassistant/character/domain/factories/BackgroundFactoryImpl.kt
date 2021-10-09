// File BackgroundFactoryImpl.kt
// @Author pierre.antoine - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.factories

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background.BackgroundDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.BackgroundModel
import com.pierreantoine.rolegameassistant.character.domain.contracts.factory.*

/**
 *   Class "BackgroundFactoryImpl" :
 *   Used to convert ui values into application values
 *   and application values into ui values.
 **/
class BackgroundFactoryImpl(
    /** Biography factory   **/
    val bioFactory: BioFactory?,
    /** Personality factory     **/
    val personalityFactory: PersonalityFactory?,
    /** Bond factory    **/
    val bondFactory: BondFactory?,
    /** Flaw factory    **/
    val flawFactory: FlawFactory?,
    /** Ideal factory   **/
    val idealFactory:IdealFactory?
)
    : BackgroundFactory{
    /**
     * From dto to domain model.
     */
    override fun toDomain(dto: BackgroundDto?): BackgroundModel? {
        return BackgroundModel(
            id = dto?.id,
            biography = bioFactory?.toDomain(dto?.bio),
            personality = personalityFactory?.toDomain(dto?.personality),
            bonds = bondFactory?.toDomain(dto?.bonds),
            flaws = flawFactory?.toDomain(dto?.flaws),
            ideals = idealFactory?.toDomain(dto?.ideals)
        )
    }

    /**
     * From domain model to dto.
     */
    override fun toDto(domainModel: BackgroundModel?): BackgroundDto? {
        return BackgroundDto(
            id = domainModel?.id,
            ideals = idealFactory?.toDto(domainModel?.ideals),
            flaws = flawFactory?.toDto(domainModel?.flaws),
            bonds = bondFactory?.toDto(domainModel?.bonds),
            personality = personalityFactory?.toDto(domainModel?.personality),
            bio = bioFactory?.toDto(domainModel?.biography)
        )
    }
}