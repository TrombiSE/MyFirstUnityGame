using UnityEngine;

public class EndTrigger : MonoBehaviour
{
    public MyGameManager myGameManager;
    
    void OnTriggerEnter()
    {
        myGameManager.CompleteLevel();
    }
}
