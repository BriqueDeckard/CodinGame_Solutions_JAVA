// File BasicInfoMapperImpl.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.mapper

import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_basic_info.DBBasicInfo
import com.pierreantoine.rolegameassistant.character.domain.aggregate.basic_info.BasicInfoModel
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.BasicInfoMapper
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.ClassMapper
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.mapper.RaceMapper

/**
 *   Class "BasicInfoMapperImpl" :
 *   TODO: Fill class use.
 **/
class BasicInfoMapperImpl (
    private val classMapper: ClassMapper?,
    private val raceMapper: RaceMapper?
) :
    BasicInfoMapper {


    override fun map(basicInfo: BasicInfoModel?): DBBasicInfo? {
        return DBBasicInfo(
            dbBasicInfo_id = basicInfo?.id,
            dbBasicInfo_level = basicInfo?.level,
            dbBasicInfo_name = basicInfo?.name,
            dbBasicInfo_classModel = classMapper?.map(basicInfo?.classModel),
            dbBasicInfo_experience = basicInfo?.experience,
            dbBasicInfo_race = raceMapper?.map(basicInfo?.race)

        )
    }
// TODO : Fill class.
}