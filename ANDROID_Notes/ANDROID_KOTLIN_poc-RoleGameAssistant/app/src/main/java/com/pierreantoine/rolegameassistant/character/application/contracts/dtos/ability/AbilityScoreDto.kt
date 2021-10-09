// File AbilityScoreDto.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.application.contracts.dtos.ability

/**
 *   Class "AbilityScoreDto" :
 *   Class used to transmi data about ability scores
 **/
data class AbilityScoreDto(
    /** Identifier **/
    var id:Int?,
    /** Ability's name **/
    var ability:String?,
    /** Roll result **/
    var roll:Int?,
    /** Bonus added **/
    var bonus:Int?,
    /** Roll's total **/
    var total:Int?
)