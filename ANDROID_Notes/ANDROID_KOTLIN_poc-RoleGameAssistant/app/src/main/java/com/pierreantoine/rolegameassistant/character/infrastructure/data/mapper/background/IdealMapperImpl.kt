// File IdealMapperImpl.kt
// @Author errei - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper.background

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background.DBIdeal
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.IdealModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.background.IdealMapper

/**
 *   Class "IdealMapperImpl" :
 *   TODO: Fill class use.
 **/
class IdealMapperImpl : IdealMapper {
    override fun map(idealModel: IdealModel?): DBIdeal? {
        return DBIdeal(
            dbIdeal_Id = idealModel?.id,
            dbIdeal_ideal = idealModel?.ideal
        )
    }
// TODO : Fill class.
}