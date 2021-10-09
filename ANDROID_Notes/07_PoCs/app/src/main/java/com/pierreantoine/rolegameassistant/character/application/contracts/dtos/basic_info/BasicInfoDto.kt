// File BasicInfoDto.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.application.contracts.dtos.basic_info

/**
 *   Class "BasicInfoDto" :
 *   Used to transmit values about basic info between ui and application layer.
 **/
class BasicInfoDto(
    /** Identifier  **/
    var id: Int?,
    /** Name    **/
    var name: String?,
    /** Level   **/
    var level: Int?,
    /** Experience  **/
    var experience: Int?,
    /** Race    **/
    var race: RaceDto?,
    /** CLass   **/
    var classDto: ClassDto?
)