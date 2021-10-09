// File FlawMapperImpl.kt
// @Author errei - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper.background

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background.DBFlaw
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.FlawModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.background.FlawMapper

/**
 *   Class "FlawMapperImpl" :
 *   TODO: Fill class use.
 **/
class FlawMapperImpl : FlawMapper {
    override fun map(flawModel: FlawModel?): DBFlaw? {
        return DBFlaw(
            dbFlaw_Id = flawModel?.id,
            dbFlaw_Flaw = flawModel?.flaw
        )
    }
// TODO : Fill class.
}