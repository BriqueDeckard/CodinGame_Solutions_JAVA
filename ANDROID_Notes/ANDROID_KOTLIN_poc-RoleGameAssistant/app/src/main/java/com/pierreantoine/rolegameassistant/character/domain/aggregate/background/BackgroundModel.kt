// File Background.kt
// @Author errei - 16/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.domain.aggregate.background

/**
 *   Class "Background" :
 *   To store background.
 **/
class BackgroundModel
    (
    var id:Int?,
    var personality:PersonalityModel?,
    var ideals:IdealModel?,
    var bonds:BondModel?,
    var flaws:FlawModel?,
    var biography:BiographyModel?
)