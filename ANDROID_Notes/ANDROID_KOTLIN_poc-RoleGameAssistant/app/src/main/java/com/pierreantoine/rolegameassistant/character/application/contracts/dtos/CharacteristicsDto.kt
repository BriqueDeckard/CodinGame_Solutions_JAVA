// File CharacteristicsDto.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.application.contracts.dtos

/**
 *   Class "CharacteristicsDto" :
 *   Values transmitted between Ui and Application layer
 **/
class CharacteristicsDto(
    /** Identifier  **/
    var id:Int?,
    /** Weight  **/
    var weight:Int?,
    /** Height  **/
    var height:Int?,
    /** Gender  **/
    var gender:String?,
    /** Age **/
    var age:Int?
)