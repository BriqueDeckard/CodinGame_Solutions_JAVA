// File PersonalityMapperImpl.kt
// @Author errei - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper.background

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background.DBPersonality
import com.pierreantoine.rolegameassistant.character.domain.aggregate.background.PersonalityModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.background.PersonalityMapper

/**
 *   Class "PersonalityMapperImpl" :
 *   TODO: Fill class use.
 **/
class PersonalityMapperImpl : PersonalityMapper {
    override fun map(personalityModel: PersonalityModel?): DBPersonality? {
        return DBPersonality(
            dbPersonality_id = personalityModel?.id,
            dbPersonality_personality = personalityModel?.personality
        )
    }
// TODO : Fill class.
}