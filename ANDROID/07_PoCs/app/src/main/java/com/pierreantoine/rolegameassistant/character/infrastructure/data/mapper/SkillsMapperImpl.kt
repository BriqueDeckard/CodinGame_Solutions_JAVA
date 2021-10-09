// File SkillsMapperImpl.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_skills.DBSkills
import com.pierreantoine.rolegameassistant.character.domain.aggregate.skills.SkillsModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.SkillsMapper

/**
 *   Class "SkillsMapperImpl" :
 *   TODO: Fill class use.
 **/
class SkillsMapperImpl : SkillsMapper {
    override fun map(skills: SkillsModel?): DBSkills? {
       return DBSkills(
           dbSkills_id =  skills?.id
       )
    }

// TODO : Fill class.
}