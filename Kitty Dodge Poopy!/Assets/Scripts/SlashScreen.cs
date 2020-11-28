using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class SlashScreen : MonoBehaviour {
	public Text splashText;
	public string loadScene;

	private IEnumerator Start()
	{
		splashText.canvasRenderer.SetAlpha (0f);
		FadeIn ();
		yield return new WaitForSeconds (2);
		FadeOut ();
		yield return new WaitForSeconds (2);
		SceneManager.LoadScene (loadScene);
	}
	void FadeIn()
	{
		splashText.CrossFadeAlpha (1f, 2f, false);
	}
	void FadeOut()
	{
		splashText.CrossFadeAlpha (0f, 2f, false);
	}
}