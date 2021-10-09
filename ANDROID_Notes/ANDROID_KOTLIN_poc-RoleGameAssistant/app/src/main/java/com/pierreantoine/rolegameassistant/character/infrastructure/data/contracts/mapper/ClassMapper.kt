package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper

import com.pierreantoine.rolegameassistant.character.domain.aggregate.basic_info.ClassModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_basic_info.DBClass

interface ClassMapper {
    fun map(classModel: ClassModel?):DBClass //    TODO : Implements mapping
}