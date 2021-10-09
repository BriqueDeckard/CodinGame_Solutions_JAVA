package com.uldskull.pocmodularity

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import com.uldskull.poc_modularity.domain.SampleDomainEntity

class MainActivity : AppCompatActivity() {

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
    }

    fun createDomain(){
        var sample = SampleDomainEntity(
            id = null,
            value = "value"
        )
    }
}
