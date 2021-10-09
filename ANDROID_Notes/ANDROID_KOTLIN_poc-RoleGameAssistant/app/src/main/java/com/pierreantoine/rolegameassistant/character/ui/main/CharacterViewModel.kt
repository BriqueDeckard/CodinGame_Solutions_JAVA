// File CharacterViewModel.kt
// @Author errei - 16/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.ui.main

import android.app.Application
import androidx.lifecycle.AndroidViewModel
import androidx.lifecycle.viewModelScope
import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.CharacterDto
import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.CharacteristicsDto
import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.HealthDto
import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.ability.AbilityScoresDto
import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.background.*
import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.basic_info.BasicInfoDto
import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.basic_info.ClassDto
import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.basic_info.RaceDto
import com.pierreantoine.rolegameassistant.character.application.contracts.dtos.skills.SkillsDto
import com.pierreantoine.rolegameassistant.character.application.contracts.services.CharacterApplicationServices
import kotlinx.coroutines.launch

/**
 *   Class "CharacterViewModel" :
 *   designed to store and manage UI-related data in a lifecycle conscious way.
 *   The ViewModel class allows data to survive configuration changes such as
 *   screen rotations.
 **/
class CharacterViewModel(application: Application, val applicationServices: CharacterApplicationServices) :
    AndroidViewModel(application) {

    init {
        var characterModel: CharacterDto = CharacterDto(
            id = null,
            abilityScores = AbilityScoresDto(
                null
            ),
            background = BackgroundDto(
                id = null,
                personality = PersonalityDto(
                    id = null,
                    personality = "personality"
                ),
                bio = BiographyDto(
                    id = null,
                    biography = "bio"
                ),
                ideals = IdealDto(
                    id = null,
                    ideal = "ideal"
                ),
                flaws = FlawDto(
                    id = null,
                    flaw = "flaw"
                ),
                bonds = BondDto(
                    id = null,
                    bond = "bond"
                )
            ),
            skills = SkillsDto(null),
            health = HealthDto(
                id = null,
                hpMod = 0,
                maxHealth = 0,
                useMax = true
            ),
            characteristics = CharacteristicsDto(
                id = null,
                weight = 0,
                height = 0,
                gender = "gender",
                age = 0
            ),
            basicInfo = BasicInfoDto(
                id = null,
                name = "name",
                race = RaceDto(
                    id = null,
                    name = "race"
                ),
                level = 7,
                experience = 10,
                classDto = ClassDto(
                    id = null,
                    name = "name"
                )
            ))

        viewModelScope.launch{
            applicationServices.insert(characterModel)
        }
    }

    /** Insert data passing by application services.    */
    fun insert(){
        var characterModel: CharacterDto = CharacterDto(
            id = null,
            abilityScores = AbilityScoresDto(
                null
            ),
            background = BackgroundDto(
                id = null,
                bonds = BondDto(
                    id = null,
                    bond = "bond"
                ),
                flaws = FlawDto(
                    id = null,
                    flaw = "flaw"
                ),
                ideals = IdealDto(
                    id = null,
                    ideal = "ideal"
                ),
                bio = BiographyDto(
                    id = null,
                    biography = "bio"
                ),
                personality = PersonalityDto(
                    id = null,
                    personality = "personality"
                )
            ),
            skills = SkillsDto(null),
            health = HealthDto(
                id = null,
                useMax = false,
                maxHealth = 0,
                hpMod = 0
            ),
            characteristics = CharacteristicsDto(
                id = null,
                weight = 0,
                age = 0,
                gender = "gender",
                height = 0
            ),
            basicInfo = BasicInfoDto(
                id = null,
                name = "name",
                race = RaceDto(
                    id = null,
                    name = "race"
                ),
                level = 7,
                experience = 10,
                classDto = ClassDto(
                    id = null,
                    name = "name"
                )
            ))

        viewModelScope.launch{
            applicationServices.insert(characterModel)
        }
    }
}