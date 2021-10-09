package com.pierreantoine.rolegameassistant.character.domain.contracts.factory

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background.BondDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.BondModel

interface BondFactory : Factory<BondDto, BondModel> {
}