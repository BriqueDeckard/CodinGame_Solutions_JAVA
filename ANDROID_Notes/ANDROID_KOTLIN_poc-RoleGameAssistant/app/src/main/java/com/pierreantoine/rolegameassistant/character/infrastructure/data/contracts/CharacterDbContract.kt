// File CharacterDatabaseContract.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts

object CharacterDbContract {
    /**
     *   Class "CharacterDatabaseContract" :
     *   TODO: Fill class use.
     **/
    class CharacterDbEntries {

        companion object {
            const val DATABASE_NAME = "character_database"

            const val CHARACTER_TABLE_NAME = "characterstable"

            const val CHARACTERISTICS_TABLE_NAME = "characteristics_table"

            const val BASIC_INFO_TABLE_NAME = "basic_info_table"

            const val HEALTH_TABLE_NAME = "health_table"

            const val BACKGROUND_TABLE_NAME = "background_table"

            const val CLASS_TABLE_NAME = "class_table"

            const val RACE_TABLE_NAME = "race_table"

            const val ABILITY_SCORES_TABLE_NAME = "ability_scores_table"

            const val ABILITY_SCORE_TABLE_NAME = "ability_score_table"

            const val CHARACTER_ID_COLUMN_NAME = "dbCharacter_id"
        }
    }
}