using UnityEngine;
using UnityEngine.SocialPlatforms;
public class Leaderboards : MonoBehaviour {
   
 
    public void Start()
    {
        Social.localUser.Authenticate(ProcessAuthentication);
    }

    void ProcessAuthentication(bool success)
    {
        if (success)
        {
            Debug.Log("Authentication successful");
            string userInfo = "Username: " + Social.localUser.userName +
                "\nUser ID: " + Social.localUser.id +
                "\nIsUnderage: " + Social.localUser.underage;
            Debug.Log(userInfo);
        }
        else
            Debug.Log("Failed to authenticate with Game Center.");
    }



}
