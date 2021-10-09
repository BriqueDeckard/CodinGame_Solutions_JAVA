// File SkillMapperImpl.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_skills.DBSkill
import com.pierreantoine.rolegameassistant.character.domain.aggregate.skills.SkillModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.SkillMapper

/**
 *   Class "SkillMapperImpl" :
 *   TODO: Fill class use.
 **/
class SkillMapperImpl : SkillMapper {

    override fun map(skill: SkillModel?): DBSkill? {
        return DBSkill(
            dbSkill_id = skill?.id,
            dbSkill_checked = skill?.checked,
            dbSkill_modifier = skill?.modifier,
            dbSkill_name = skill?.name
        )
    }
// TODO : Fill class.
}