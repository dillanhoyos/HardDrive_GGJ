using UnityEngine;

public class Sound : MonoBehaviour
{
	public static Sound soundSG;

	public AudioSource sounder;

	private void Awake()
	{
		if (soundSG != null && soundSG != this)
		{
			UnityEngine.Object.Destroy(base.gameObject);
			return;
		}
		soundSG = this;
		Object.DontDestroyOnLoad(base.gameObject);
	}
}
