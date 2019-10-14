using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using RPG.Saving;

namespace RPG.SceneManagement
{
    public class SavingWrapper : MonoBehaviour
    {
        const string deafualtSaveFile = "save";

        // Update is called once per frame
        void Update()
        {
            if (Input.GetKeyDown(KeyCode.L))
            {
                Load();
            }

            if (Input.GetKeyDown(KeyCode.S))
            {
                Save();
            }
        }

        private void Save()
        {
            //call to saving system
            GetComponent<SavingSystem>().Save(deafualtSaveFile);
        }

        private void Load()
        {
            //call to saving system 
            GetComponent<SavingSystem>().Load(deafualtSaveFile);
        }
    }
}

