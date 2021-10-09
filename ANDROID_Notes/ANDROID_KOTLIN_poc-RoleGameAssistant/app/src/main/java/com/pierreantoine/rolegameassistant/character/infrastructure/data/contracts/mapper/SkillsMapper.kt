// File SkillsMapper.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_skills.DBSkills
import com.pierreantoine.rolegameassistant.character.domain.aggregate.skills.SkillsModel

/**
 *   Interface "SkillsMapper" :
 *   TODO: Fill interface use.
 **/
interface SkillsMapper {
    fun map(skills:SkillsModel?):DBSkills?
// TODO : Fill interface.
}