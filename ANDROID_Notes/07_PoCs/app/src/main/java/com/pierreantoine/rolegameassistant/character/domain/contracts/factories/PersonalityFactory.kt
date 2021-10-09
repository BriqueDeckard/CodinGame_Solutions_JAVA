package com.pierreantoine.rolegameassistant.character.domain.contracts.factory

import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background.PersonalityDto
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.PersonalityModel

interface PersonalityFactory : Factory<PersonalityDto, PersonalityModel> {
}