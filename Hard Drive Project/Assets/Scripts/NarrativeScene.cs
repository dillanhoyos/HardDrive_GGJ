using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NarrativeScene : MonoBehaviour
{
	public TMP_Text textoCargado;

	public string nivelACargar;

	private void Start()
	{
		StartCoroutine(iniciarCarga());
	}

	private IEnumerator iniciarCarga()
	{
		yield return new WaitForSeconds(0.5f);
		AsyncOperation operacion = SceneManager.LoadSceneAsync(nivelACargar);
		operacion.allowSceneActivation = false;
		while (!operacion.isDone)
		{
			if (operacion.progress >= 0.9f)
			{
				textoCargado.text = "Presiona cualquier cosa para continuar";
				if (Input.anyKey)
				{
					operacion.allowSceneActivation = true;
				}
			}
			yield return null;
		}
	}
}
