using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Mort : MonoBehaviour
{
    public class Fin : MonoBehaviour
    {
        private void OnTriggerEnter(Collider mort)
        {
            if (mort.name == "First person player")
            {
                Debug.Log("re");
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            }
        }
    }

}
