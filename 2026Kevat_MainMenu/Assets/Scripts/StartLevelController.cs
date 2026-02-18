using UnityEngine;

public class StartLevelController : MonoBehaviour
{

    public FadeController fade;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        fade.FadeOut();    
    }

}
