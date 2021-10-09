// File MainApplication.kt
// @Author pierre.antoine - 18/01/2020 - No copyright.

package com.uldskull.poc_koin.application.api

import android.app.Application
import com.uldskull.poc_koin.infrastructure.cross_cutting.appModule
import org.koin.android.ext.koin.androidContext
import org.koin.android.ext.koin.androidLogger
import org.koin.core.context.startKoin

/**
 *   Class "MainApplication" :
 *   TODO: Fill class use.
 **/
class MainApplication : Application() {
// TODO : Fill class.

    override fun onCreate() {
        super.onCreate()

        startKoin {
            androidContext(this@MainApplication)
            androidLogger()
            modules(appModule)
        }
    }
}