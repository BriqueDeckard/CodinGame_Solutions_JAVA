// File BioMapperImpl.kt
// @Author errei - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper.background

import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.BiographyModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background.DBBio
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.background.BioMapper

/**
 *   Class "BioMapperImpl" :
 *   TODO: Fill class use.
 **/
class BioMapperImpl : BioMapper {
    override fun map(biographyModel: BiographyModel?): DBBio? {
        return DBBio(
            dbBio_Id = biographyModel?.id,
            dbBio_bio = biographyModel?.biography
        )
    }
// TODO : Fill class.
}