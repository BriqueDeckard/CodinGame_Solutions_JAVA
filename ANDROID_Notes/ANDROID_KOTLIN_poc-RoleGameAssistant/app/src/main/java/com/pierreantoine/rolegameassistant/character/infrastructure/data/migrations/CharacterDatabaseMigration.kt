// File CharacterDatabaseMigration.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.infrastructure.data.migrations

import androidx.room.migration.Migration
import androidx.sqlite.db.SupportSQLiteDatabase

/**
 *   Class "CharacterDatabaseMigration" :
 *   USed to migrate database.
 **/
val MIGRATION_0_1: Migration = object : Migration(0, 1){
    override fun migrate(database: SupportSQLiteDatabase) {

    }
}