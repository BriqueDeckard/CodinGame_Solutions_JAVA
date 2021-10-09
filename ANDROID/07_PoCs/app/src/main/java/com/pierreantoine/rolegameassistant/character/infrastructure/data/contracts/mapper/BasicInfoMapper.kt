// File BasicInfoMapper.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_basic_info.DBBasicInfo
import com.pierreantoine.rolegameassistant.character.domain.aggregate.basic_info.BasicInfoModel

/**
 *   Class "BasicInfoMapper" :
 *   TODO: Fill class use.
 **/
interface BasicInfoMapper {
    fun map(basicInfo: BasicInfoModel?):DBBasicInfo?

}