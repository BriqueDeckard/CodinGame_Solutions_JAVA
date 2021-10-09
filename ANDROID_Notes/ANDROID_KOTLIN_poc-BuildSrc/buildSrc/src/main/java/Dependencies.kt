// File Dependencies.kt
// @Author pierre.antoine - 26/01/2020 - No copyright.
object Versions {
    const val roomVersion = "2.2.1"
    const val appCompatVersion = "1.1.0"
    const val androidxCoreKtxVersion = "1.1.0"
    const val constraintLayoutVersion = "1.1.3"
    const val junitVersion = "4.12"
    const val extJunitVersion = "1.1.1"
    const val espressoCoreVersion = "3.2.0"
    const val archLifecycleVersion = "2.2.0-rc02"
    const val androidxArchVersion = "2.1.0"
    const val coroutinesVersion = "1.3.2"
    const val koinVersion= "2.0.1"


}


object TestDependencies {
    const val junit = "junit:junit:${Versions.junitVersion}"
    const val extJunit = "androidx.test.ext:junit:${Versions.extJunitVersion}"
    const val espressoCore = "androidx.test.espresso:espresso-core:${Versions.espressoCoreVersion}"
    const val archCore = "androidx.arch.core:core-testing:${Versions.androidxArchVersion}"
    const val koinTest = "org.koin:koin-test:${Versions.koinVersion}"
}

object AndroidxDependencies {
    const val androidxAppCompat = "androidx.appcompat:appcompat:${Versions.appCompatVersion}"
    const val androidxCoreKtx = "androidx.core:core-ktx:${Versions.androidxCoreKtxVersion}"
    const val androidxConstraintLayout =
        "androidx.constraintlayout:constraintlayout:${Versions.constraintLayoutVersion}"
}

object RoomDependencies {
    const val roomRuntime = "androidx.room:room-runtime:${Versions.roomVersion}"
    const val roomKtx = "androidx.room:room-ktx:${Versions.roomVersion}"
    const val roomRxJava = "androidx.room:room-rxjava2:${Versions.roomVersion}"
    const val roomCompiler = "androidx.room:room-compiler:${Versions.roomVersion}"
    const val roomTesting = "androidx.room:room-testing:${Versions.roomVersion}"
}

object LifecycleDependencies {
    const val lifecycleExtension =
        "androidx.lifecycle:lifecycle-extensions:${Versions.archLifecycleVersion}"
    const val lifecycleCompiler =
        "androidx.lifecycle:lifecycle-compiler:${Versions.archLifecycleVersion}"
    const val lifecycleViewModelKtx =
        "androidx.lifecycle:lifecycle-viewmodel-ktx:${Versions.archLifecycleVersion}"
}

object CoroutinesDependencies {
    const val kotlinxCoroutines =
        "org.jetbrains.kotlinx:kotlinx-coroutines-android:${Versions.coroutinesVersion}"
}

object IoCDependencies {
    const val koinCore = "org.koin:koin-core:${Versions.koinVersion}"
}