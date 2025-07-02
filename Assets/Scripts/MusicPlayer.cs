using UnityEngine;

public class MusicPlayer : MonoBehaviour
{
    
    void Start()
    {
        int mpnumber = FindObjectsByType<MusicPlayer>(FindObjectsSortMode.None).Length;
        if(mpnumber > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }

   
}
