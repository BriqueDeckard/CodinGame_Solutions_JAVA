// File SkillMapper.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_skills.DBSkill
import com.pierreantoine.rolegameassistant.character.domain.aggregate.skills.SkillModel

/**
 *   Interface "SkillMapper" :
 *   TODO: Fill interface use.
 **/
interface SkillMapper {

    fun map(skill:SkillModel?):DBSkill?
// TODO : Fill interface.
}