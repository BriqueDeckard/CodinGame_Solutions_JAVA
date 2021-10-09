// File MainApplication.kt
// @Author errei - 21/01/2020 - No copyright.

package com.pierreantoine.rolegameassistant.character.application

import android.app.Application
import com.pierreantoine.rolegameassistant.character.infrastructure.cross_cutting.modules.*
import org.koin.android.ext.koin.androidContext
import org.koin.android.ext.koin.androidLogger
import org.koin.core.context.startKoin

/**
 *   Class "MainApplication" :
 *   Application class used to start Koin.
 **/
class MainApplication : Application() {

    /**
     * Override onCreate to start Koin within the application
     * lifecycle
     */
    override fun onCreate() {
        super.onCreate()

        startKoin {
            androidContext(this@MainApplication)
            androidLogger()
            modules(mappersModule)
            modules(factoriesModule)
            modules(dbModule)
            modules(daoModule)
            modules(repositoryModule)
            modules(applicationServicesModule)
            modules(viewModelModule)

        }
    }
}