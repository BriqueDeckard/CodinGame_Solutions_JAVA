// File BackgroundMapperImpl.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper.background

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background.DBBackground
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.BackgroundModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.background.*

/**
 *   Class "BackgroundMapperImpl" :
 *   TODO: Fill class use.
 **/
class BackgroundMapperImpl(
    private val personalityMapper: PersonalityMapper,
    private val bioMapper: BioMapper,
    private val bondMapper: BondMapper,
    private val flawMapper: FlawMapper,
    private val idealMapper: IdealMapper
) :
    BackgroundMapper {
    override fun map(background: BackgroundModel?): DBBackground? {
        return DBBackground(
            dbBackground_id = background?.id,
            dbBackground_personality = personalityMapper.map(background?.personality),
            dbBackground_bio = bioMapper.map(background?.biography),
            dbBackground_bonds = bondMapper.map(background?.bonds),
            dbBackground_flaws = flawMapper.map(background?.flaws),
            dbBackground_ideals = idealMapper.map(background?.ideals)
        )
    }
}