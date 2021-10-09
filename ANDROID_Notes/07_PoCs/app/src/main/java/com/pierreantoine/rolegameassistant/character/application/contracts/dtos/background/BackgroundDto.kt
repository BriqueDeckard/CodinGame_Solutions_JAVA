// File BackgroundDto.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background

/**
 *   Class "BackgroundDto" :
 *   Used to transmit data between ui and application layer
 **/
class BackgroundDto(
    /** identifier **/
    var id:Int?,
    /** dto about personality **/
    var personality:PersonalityDto?,
    /** dto about ideals **/
    var ideals:IdealDto?,
    /** dto about bonds **/
    var bonds:BondDto?,
    /** dto about flaws **/
    var flaws:FlawDto?,
    /** dto about biography **/
    var bio:BiographyDto?
)