// File DBBackground.kt
// @Author errei - 16/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background

import androidx.room.Embedded
import androidx.room.Entity
import androidx.room.PrimaryKey
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.CharacterDbContract.CharacterDbEntries.Companion.BACKGROUND_TABLE_NAME

/**
 *   Class "DBBackground" :
 *   TODO: Fill class use.
 **/
@Entity(tableName = BACKGROUND_TABLE_NAME)
class DBBackground(
    @PrimaryKey(autoGenerate = true)
    var dbBackground_id:Int?,
    @Embedded
    var dbBackground_personality: DBPersonality?,
    @Embedded
    var dbBackground_ideals: DBIdeal?,
    @Embedded
    var dbBackground_bonds: DBBond?,
    @Embedded
    var dbBackground_flaws: DBFlaw?,
    @Embedded
    var dbBackground_bio: DBBio?
) {
// TODO : Fill class.
}