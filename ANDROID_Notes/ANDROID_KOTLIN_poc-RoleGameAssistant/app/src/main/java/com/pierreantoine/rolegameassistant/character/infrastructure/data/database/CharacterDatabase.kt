// File CharacterDatabase.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.database

import android.content.Context
import androidx.room.Database
import androidx.room.Room
import androidx.room.RoomDatabase
import androidx.sqlite.db.SupportSQLiteDatabase
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.daos.CharacterDao
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.CharacterDbContract.CharacterDbEntries.Companion.DATABASE_NAME
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.daos.BasicInfoDao
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_background.DBBackground
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.DBCharacter
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.DBCharacteristics
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.DBHealth
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_ability.DBAbilityScore
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_ability.DBAbilityScores
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_basic_info.DBBasicInfo
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_basic_info.DBClass
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_basic_info.DBRace
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_skills.DBSkill
import com.pierreantoine.rolegameassistant.character.infrastructure.data.db_data.db_skills.DBSkills
import com.pierreantoine.rolegameassistant.character.infrastructure.data.migrations.MIGRATION_0_1
import kotlinx.coroutines.CoroutineScope
import kotlinx.coroutines.launch

/**
 *   Class "CharacterDatabase" :
 *   Direct access to sqlite database.
 **/
@Database(
    entities = [DBCharacter::class,
        DBBasicInfo::class,
        DBCharacteristics::class,
        DBAbilityScores::class,
        DBAbilityScore::class,
        DBBackground::class,
        DBHealth::class,
        DBSkill::class,
        DBSkills::class,
        DBClass::class,
        DBRace::class],


    version = 1, exportSchema = false
)
//@TypeConverters(Converter::class)
abstract class CharacterDatabase : RoomDatabase() {

    abstract fun characterDao(): CharacterDao?

    abstract fun basicInfoDao() : BasicInfoDao?

    companion object {
        //  Singleton database.
        @Volatile
        private var INSTANCE: CharacterDatabase? = null

        //  Get the singleton database
        fun getDatabase(
            context: Context,
            scope: CoroutineScope
        ): CharacterDatabase? {

            if (INSTANCE != null) {
                return INSTANCE
            }

            synchronized(this) {
                /*
                INSTANCE = Room.inMemoryDatabaseBuilder(
                    context.applicationContext,
                    CharacterDatabase::class.java
                )
                    .addCallback(
                        CharacterDatabaseCallback(
                            scope
                        )
                    )
                    .build()
                return INSTANCE

                 */
                val instance = Room.databaseBuilder(
                    context.applicationContext,
                    CharacterDatabase::class.java,
                    DATABASE_NAME
                )
                    .addCallback(
                        CharacterDatabaseCallback(
                            scope
                        )
                    )
                    .addMigrations(MIGRATION_0_1)
                    .build()
                INSTANCE = instance
            }
            return INSTANCE


        }

        /**
         *   Class "CharacterDatabaseCallback" :
         *   Callback for character database
         **/
        private class CharacterDatabaseCallback(
            private val scope: CoroutineScope
        ) : RoomDatabase.Callback() {
            override fun onOpen(db: SupportSQLiteDatabase) {
                super.onOpen(db)
                INSTANCE?.let { database ->
                    scope.launch {
                      //  populateDatabase(database.characterDao())
                    }
                }

            }

            /**
             * Populate the databasefor testing
             */
            suspend fun populateDatabase(characterDao: CharacterDao?) {
                //  Delete all content
              //  characterDao?.deleteAll()
/*
                //  Add one sample character
                val character =
                    DBCharacter(
                        dbCharacter_id = null,
                        dbCharacter_basicInfo =  DBBasicInfo(
                            dbBasicInfo_id =  null,
                            dbBasicInfo_classModel =  null,
                            dbBasicInfo_experience =  null,
                            dbBasicInfo_level =  null,
                            dbBasicInfo_name =  null,
                            dbBasicInfo_race =  null
                        ),
                        dbCharacter_characteristics = DBCharacteristics(
                            dbCharacteristics_age = null,
                            dbCharacteristics_gender = null,
                            dbCharacteristics_height = null,
                            dbCharacteristics_id = null,
                            dbCharacteristics_weight = null
                        ),
                        dbCharacter_background = DBBackground(
                            dbBackground_bio = null,
                            dbBackground_bonds = null,
                            dbBackground_flaws = null,
                            dbBackground_id = null,
                            dbBackground_ideals = null,
                            dbBackground_personality = null
                        ),
                        dbCharacter_abilityScores = DBAbilityScores(
                                dbAbilityScores_id = null
                            ),
                        dbCharacter_health = DBHealth(
                            dbHealth_id = null,
                            dbHealth_hpMod = null,
                            dbHealth_useMax = false),
                        dbCharacter_skills = DBSkills(
                            dbSkills_id = null)
                    )
*/
                //val character = DBCharacter(null, )
                // characterDao?.insert(character)
            }
        }
    }
}