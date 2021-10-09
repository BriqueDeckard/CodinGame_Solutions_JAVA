package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.background

import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.BiographyModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background.DBBio

interface BioMapper {
    fun map(biographyModel:BiographyModel?): DBBio?
}