// File ClassMapperImpl.kt
// @Author errei - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper

import com.pierreantoine.rolegameassistant.character.domain.aggregate.basic_info.ClassModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.ClassMapper
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_basic_info.DBClass

/**
 *   Class "ClassMapperImpl" :
 *   TODO: Fill class use.
 **/
class ClassMapperImpl : ClassMapper {
    override fun map(classModel: ClassModel?): DBClass {
        return DBClass(
            dbClass_id = null,
            dbClass_name = classModel?.name
        )
    }
// TODO : Fill class.
}