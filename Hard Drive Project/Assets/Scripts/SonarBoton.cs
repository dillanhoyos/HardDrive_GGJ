using UnityEngine;

public class SonarBoton : MonoBehaviour
{
	[SerializeField]
	private AudioClip Clip;

	public void Sonar()
	{
		Sound.soundSG.sounder.clip = Clip;
		Sound.soundSG.sounder.Play();
	}
}
