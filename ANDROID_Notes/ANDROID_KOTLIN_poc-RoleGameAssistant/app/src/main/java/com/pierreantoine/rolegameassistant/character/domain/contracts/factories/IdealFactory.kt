package com.pierreantoine.rolegameassistant.character.domain.contracts.factory

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background.IdealDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.IdealModel

interface IdealFactory : Factory<IdealDto, IdealModel> {
}