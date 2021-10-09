// File BasicInfo.kt
// @Author errei - 16/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.aggregate.basic_info

/**
 *   Class "BasicInfo" :
 *   To store basic informations
 **/
class BasicInfoModel(
    var id: Int?,
    var name: String?,
    var level: Int?,
    var experience: Int?,
    var race: RaceModel?,
    var classModel: ClassModel?
)