using UnityEngine;

public class SFX : MonoBehaviour
{
	public AudioClip Clip;

	protected AudioSource fuente;

	private void Start()
	{
		fuente = GetComponent<AudioSource>();
	}
}
