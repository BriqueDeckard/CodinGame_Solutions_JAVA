package com.pierreantoine.rolegameassistant.character.domain.contracts.factory

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background.BiographyDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.BiographyModel

interface BioFactory : Factory<BiographyDto, BiographyModel> {
}