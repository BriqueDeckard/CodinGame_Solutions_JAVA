package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.background

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background.DBPersonality
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.PersonalityModel

interface PersonalityMapper {

    fun map(personalityModel: PersonalityModel?): DBPersonality?
}