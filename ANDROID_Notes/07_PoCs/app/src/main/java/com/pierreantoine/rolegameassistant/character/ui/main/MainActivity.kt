package com.pierreantoine.rolegameassistant.character.ui.main

import androidx.appcompat.app.AppCompatActivity
import android.os.Bundle
import android.view.View
import com.pierreantoine.rolegameassistant.R
import com.pierreantoine.rolegameassistant.character.infrastructure.data.contracts.CharacterDbContract.CharacterDbEntries.Companion.DATABASE_NAME
import kotlinx.android.synthetic.main.activity_main.*
import org.koin.androidx.viewmodel.ext.android.getViewModel

class MainActivity : AppCompatActivity() {

    private lateinit var characterViewModel: CharacterViewModel

    override fun onCreate(savedInstanceState: Bundle?) {
        super.onCreate(savedInstanceState)
        setContentView(R.layout.activity_main)
        application.deleteDatabase(DATABASE_NAME)

       characterViewModel = getViewModel()

     /*  button.setOnClickListener(
            View.OnClickListener {
                characterViewModel.insert()
            }
        )
*/

    }


}
