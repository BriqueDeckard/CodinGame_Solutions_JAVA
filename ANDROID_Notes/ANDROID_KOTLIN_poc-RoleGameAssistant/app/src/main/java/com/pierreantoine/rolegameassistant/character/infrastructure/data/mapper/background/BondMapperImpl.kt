// File BondMapperImpl.kt
// @Author errei - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper.background

import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.BondModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background.DBBond
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.background.BondMapper

/**
 *   Class "BondMapperImpl" :
 *   TODO: Fill class use.
 **/
class BondMapperImpl : BondMapper {
    override fun map(bondModel: BondModel?): DBBond? {
        return DBBond(
            dbBond_bond = bondModel?.bond,
            dbBond_Id = bondModel?.id
        )
    }
// TODO : Fill class.
}