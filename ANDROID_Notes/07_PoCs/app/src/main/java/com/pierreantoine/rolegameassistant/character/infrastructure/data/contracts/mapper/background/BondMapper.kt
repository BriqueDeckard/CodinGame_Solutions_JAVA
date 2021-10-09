package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.background

import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.BondModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background.DBBond

interface BondMapper {

    fun map(bondModel: BondModel?): DBBond?
}