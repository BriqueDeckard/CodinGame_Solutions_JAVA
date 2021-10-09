package com.pierreantoine.rolegameassistant.character.domain.contracts.factory

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background.FlawDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.FlawModel

interface FlawFactory : Factory<FlawDto, FlawModel> {
}