using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    public AudioSource music;
    // Start is called before the first frame update
    
        private void Awake()
        {
            GameObject[] objs = GameObject.FindGameObjectsWithTag("Music");

            if (objs.Length > 1)
            {
                Destroy(this.gameObject);
            }
            else
            {
                DontDestroyOnLoad(this.gameObject);
            }
        }
    
}
